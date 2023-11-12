using IDCoreTest.ContextDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System.Transactions;
using IDCoreTest.Models;
using IDCoreTest.Helpers;
using System.Linq;

using System.Linq.Expressions;
using System.Reflection.Metadata;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Globalization;
using Azure.Core;
using System.Text.Json;
using Microsoft.Extensions.Localization;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDCoreTest.Controllers
{
    [ApiController]
    [Route("caa")]
    public class CustomersAndAreasController : Controller
    {
        private readonly AppContextDB _context;
        private readonly ILogger<CustomersAndAreasController> _logger;
        public readonly IStringLocalizer<CustomersAndAreasController> _localizer;
        private readonly IMapper _mapper;
        public CustomersAndAreasController(IMapper mapper,IStringLocalizer<CustomersAndAreasController> localizer, AppContextDB context, ILogger<CustomersAndAreasController> logger)
        {
            _mapper = mapper;
            _context = context;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        [Route("updateCustomers")]
        public async Task<ActionResult> UpdateCustomers(string accessToken)
        {
            SubmitResponseStatusModel result = new SubmitResponseStatusModel();
            // TransactionManager transactionManager = null;
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, "Looks up a localized string similar to Invalid Access Token");
                    //Common.logger.Warn("IDM | CAA | Update Customers for Invalid AccessToken {0}", accessToken);

                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);

                }
                //var customers = _context.TblCustomers.ToList();

                result.SetResult(true, "Looks up a localized string similar to Data has been processed successfully!");
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }

        [HttpGet]
        [Route("getCustomersByWorkingArea")]
        public async Task<ActionResult> GetCustomersByWorkingArea(string accessToken, string ids = null)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();

            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }

                string[] areaIDs = new string[] { };
                if (ids != null)
                    areaIDs = ids.Split(',');

                string[] routesIDs = Common.GetBranchRoutes(clientcode, _context, user.FldBranchId);
                //query.AppendIn(CustomerColumn.FldRouteId, routesIDs);
                List<TblCustomer> resultList = await _context.TblCustomers.Where(p =>
                                                       !p.FldIsDeleted &&
                                                        areaIDs.Contains(p.FldWorkingAreaId.ToString()) &&
                                                        routesIDs.Contains(p.FldRouteId.ToString())).ToListAsync();

                result.SetResult(true);

                result.Items = (object)(resultList);
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }

        [HttpGet]
        [Route("getCustomersByNameOrCode")]
        public async Task<ActionResult> GetCustomersByNameOrCode(string accessToken, string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }
                value = System.Web.HttpUtility.UrlDecode(value);
                string[] routesIDs = null;
                if (user.FldBranchId.HasValue)
                {
                    routesIDs = Common.GetBranchRoutes(clientcode, _context, user.FldBranchId);
                }
                var resultList = await _context.TblCustomers.Where(x =>
                                                       (x.FldName.Contains(value) ||
                                                        x.FldTranslatedName.Contains(value) ||
                                                        x.FldCustomerCode.Contains(value) ||
                                                        x.FldCustomerId.ToString().Contains(value)) &&
                                                        !x.FldIsDeleted &&
                                                        (routesIDs == null || routesIDs.Contains(x.FldRouteId.ToString()))
                                                        ).ToListAsync();
                result.SetResult(true);
                result.Items = (object)(resultList);
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }
        [HttpGet]
        [Route("getCustomers")]
        public async Task<ActionResult> GetCustomers(string accessToken, int sync = 0, string from = null, string to = null)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {

                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {

                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }
                if (from == null)
                    from = DateTime.Now.ToString("yyyy-MM-dd");

                if (to == null)
                    to = from;
                to = to + " 23:59:59";

                List<TblCustomer> resultList = new List<TblCustomer>();

                CustomerParameterBuilder query = new CustomerParameterBuilder();

                query.Append(x => x.FldIsDeleted == false);

                if (sync == 1)
                {
                    if (clientcode == "WATNY")
                    {
                        query.Append(x => x.FldIntegrationAccountId == null);
                    }
                    else
                    {
                        query.Append(x => x.FldIntegrationPartyId == null);
                    }
                }
                else
                {
                    query.Append(x => x.FldCreateDate > Convert.ToDateTime(from));
                    query.Append(x => x.FldCreateDate < Convert.ToDateTime(to));


                    string[] routesIDs = Common.GetBranchRoutes(clientcode, _context, user.FldBranchId);
                    query.Append(x => routesIDs.Contains(x.FldRouteId.ToString()));
                }

                // Build the final expression
                Expression<Func<TblCustomer, bool>> finalExpression = query.Build();



                resultList = await _context.TblCustomers.Where(finalExpression).ToListAsync();
                result.SetResult(true);
                result.Items = (object)(resultList);
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }

        [HttpGet]
        [Route("getCustomerAssets")]
        public async Task<ActionResult> GetCustomerAssets(string accessToken, long id)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }
                List<TblAsset> assets = await _context.TblAssets.Where(x => x.FldCustomerId == id).ToListAsync();

                var photoFilter = new string[] { "37", "371", "372", "373", "374" };
                List<TblAppPhoto> assetsPhotos = await _context.TblAppPhotos.Where(x => photoFilter.Contains(x.FldType.ToString())).ToListAsync();

                result.Items = (assets.Select(a => new AssetModel(a, assetsPhotos.Where(p => p.FldAssetId == a.FldId).Select(c => new PhotoModel(c)).ToList())));

                result.SetResult(true);

                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }
        [HttpGet]
        [Route("getCustomerAttachments")]
        public async Task<ActionResult> GetCustomerAttachments(string accessToken, long id)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }

                // Get Attachments

                var photoFilter = new string[] { "31", "32", "33", "34", "35", "36", "38", "39" };
                List<TblAppPhoto> attachments = await _context.TblAppPhotos.Where(x => x.FldCustomerId == id && photoFilter.Contains(x.FldType.ToString())).ToListAsync();

                result.Items = (object)(attachments);

                result.SetResult(true);

                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }
        [HttpGet]
        [Route("getCustomerHistory")]
        public async Task<ActionResult> GetCustomerHistory(string accessToken, long id)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }

                List<HtblCustomer> resultList = await _context.HtblCustomers.Where(x => x.FldCustomerId == id).OrderByDescending(x => x.FldCreateDate).ToListAsync();

                result.SetResult(true);
                result.Items = (object)resultList;
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }

        [HttpGet]
        [Route("getCustomersByRoutes")]
        public async Task<ActionResult> GetCustomersByRoutes(string accessToken, string ids = null)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();

            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }

                string[] routesIDs = new string[] { };
                if (ids != null)
                    routesIDs = ids.Split(',');

                //Get Route Plans

                List<TblRoutePlan> routePlans = await _context.TblRoutePlans.Where(x => !x.FldIsDeleted && routesIDs.Contains(x.FldRouteId.ToString())).ToListAsync();


                List<TblCustomer> resultList = new List<TblCustomer>();
                foreach (TblRoutePlan routePlan in routePlans)
                {
                    List<TblPlanItem> planItems = await _context.TblPlanItems.Where(x => x.FldPlanId == routePlan.FldPlanId)
                                                                               .Include(x => x.FldCustomer)
                                                                               .Include(x => x.FldPlan)
                                                                               .ToListAsync();

                    foreach (TblPlanItem item in planItems)
                    {

                        if (item.FldCustomer != null && !resultList.Exists(c => c.FldCustomerId == item.FldCustomer.FldCustomerId))
                        {
                            resultList.Add(item.FldCustomer);
                        }
                    }

                }

                CustomerParameterBuilder cquery = new CustomerParameterBuilder();
                if (routesIDs.Length > 0)
                    cquery.Append(x => routesIDs.Contains(x.FldRouteId.ToString()));
                Expression<Func<TblCustomer, bool>> finalExpression = cquery.Build();

                List<TblCustomer> customers = await _context.TblCustomers
                                                            .Where(finalExpression)
                                                            .ToListAsync();

                foreach (TblCustomer customer in customers)
                {
                    //Ehab 17122020 I was putting this condition here (customer.FldIsActive) and I do not know why?
                    if (!customer.FldIsDeleted && !resultList.Exists(c => c.FldCustomerId == customer.FldCustomerId))
                    {
                        resultList.Add(customer);
                    }
                }
                result.SetResult(true);
                result.Items = (object)(resultList);
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }
        [HttpGet]
        [Route("getPaymentsByCustomer")]
        public async Task<ActionResult> GetPaymentsByCustomer(string accessToken, long value)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }
                //This check is to pevent user from one branch to access data related to another branch
                if (user.FldBranchId.HasValue)
                {
                    TblCustomer customer = await _context.TblCustomers.Where(x => x.FldCustomerId == value).FirstOrDefaultAsync();
                    TblRoute route = await _context.TblRoutes.Where(x => x.FldVanId == (customer.FldRouteId ?? 0)).FirstOrDefaultAsync();
                    if (route != null && route.FldBranchId != user.FldBranchId)
                    {
                        LogsServices.LogError($"IDM GetPaymentsByCustomer UnAuthorized Trial by AccessToken {accessToken} - Cutomer {value} ");
                    }
                }
                List<TblPayment> resultList = await _context.TblPayments.Where(x => x.FldCustomerId == value).ToListAsync();
                result.SetResult(true);
                result.Items = (object)(resultList);
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }
        [HttpGet]
        [Route("getCustomerVisitsByCustomer")]
        public async Task<ActionResult> GetCustomerVisitsByCustomer(string accessToken, long value, int withInvoices = 0)
        {
            GetResponseStatusModel result = new GetResponseStatusModel();
            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);

                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }
                //This check is to pevent user from one branch to access data related to another branch
                if (user.FldBranchId.HasValue)
                {
                    TblCustomer? customer = await _context.TblCustomers.Where(x => x.FldCustomerId == value).FirstOrDefaultAsync();
                    TblRoute? route = await _context.TblRoutes.Where(x => x.FldRouteId == (customer.FldRouteId ?? 0)).FirstOrDefaultAsync();
                    if (route != null && route.FldBranchId != user.FldBranchId)
                    {
                        LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");

                    }
                }


                List<TblCustomerVisit> resultList = new List<TblCustomerVisit>();

                if (withInvoices == 1)
                {
                    _context.ChangeTracker.LazyLoadingEnabled = false;
                    resultList = await _context.TblCustomerVisits.Where(x => x.FldCustomerId == value)
                                                .Include(x => x.FldNoSalesReason).AsSplitQuery()
                                                .Include(x => x.TblInvoices)
                                                .ThenInclude(i => i.TblInvoiceLineItems).ThenInclude(p => p.FldProduct).AsSplitQuery()
                                                .Include(x => x.FldRoute).ThenInclude(i => i.FldSalesman).AsSplitQuery()
                                                .ToListAsync();
                }
                else
                {
                    _context.ChangeTracker.LazyLoadingEnabled = false;
                    resultList = _context.TblCustomerVisits
                                                .Include(x => x.FldRoute)
                                                .Include(x => x.FldCustomer)
                                                .Include(x => x.FldNoSalesReason)
                                                .Where(x => x.FldCustomerId == value)
                                                .ToList();

                }
                result.SetResult(true);
                result.Items = (object)(resultList);
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }
        }

        [HttpPost]
        [Route("syncCustomer")]
        public async Task<ActionResult> SyncCustomer([FromBody] UpsertEntityModel model)
        {

            SubmitResponseStatusModel result = new SubmitResponseStatusModel();
            try
            {
                TblUser callerUser = Common.GetUserFromAccessToken(model.AccessToken, _context, out string clientcode);
                if (callerUser == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {model.AccessToken}");
                    return Json(result);
                }
                string lng = model.Lng.ToUpper();
                if (lng == "EN")
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                else
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ar-AE");
                string jsonString = JsonSerializer.Serialize(model.Entity);
                TblCustomer item = JsonSerializer.Deserialize<TblCustomer>(jsonString);

                if (string.IsNullOrWhiteSpace(item.FldIntegrationPartyId))
                    await _context.TblCustomers.AddAsync(item);
                else
                    _context.TblCustomers.Update(item);
                await _context.SaveChangesAsync();
                result.SetResult(true, item.FldCustomerId, item.FldCreateDate, "Looks up a localized string similar to Data has been processed successfully!");
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {model.AccessToken}");
                return Json(result);
            }

            return Json(result);
        }
        [HttpPost]
        [Route("upsertCustomer")]
        public async Task<ActionResult> UpsertCustomer([FromBody] UpsertEntityModel model)
        {

            SubmitResponseStatusModel result = new SubmitResponseStatusModel();

            try
            {
                TblUser callerUser = Common.GetUserFromAccessToken(model.AccessToken, _context, out string clientcode);
                if (callerUser == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {model.AccessToken}");
                    return Json(result);
                }
                string lng = model.Lng.ToUpper();
                if (lng == "EN")
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                else
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ar-AE");



                string jsonString = JsonSerializer.Serialize(model.Entity);
                TblCustomer item = JsonSerializer.Deserialize<TblCustomer>(jsonString);

                // fill default values:
                if (string.IsNullOrWhiteSpace(item.FldCustomerCode))
                    item.FldCustomerCode = "new";

                if (item.FldMobilePhone == null)
                    item.FldMobilePhone = item.FldTelephone;

                if (string.IsNullOrWhiteSpace(item.FldPlaceOfSupply))
                    item.FldPlaceOfSupply = "NA";

                TblWorkingArea? warea = await _context.TblWorkingAreas.Where(x => x.FldWorkingAreaId == item.FldWorkingAreaId).FirstOrDefaultAsync();

                if (string.IsNullOrWhiteSpace(item.FldAddress))
                {
                    item.FldAddress = warea.FldName;
                }
                item.FldIsVisible = true;
                //item.FldIsActive = true;
                item.FldZoomLevel = 16;

                TblAdminArea? adminArea = await _context.TblAdminAreas.Where(x => x.FldAreaId == warea.FldAdminAreaId).FirstOrDefaultAsync();
                TblActivity? activity = await _context.TblActivities.Where(x => x.FldId == item.FldActivityId).FirstOrDefaultAsync();
                TblCategory? category = await _context.TblCategories.Where(x => x.FldId == item.FldCategoryId).FirstOrDefaultAsync();
                TblCategory? accessChannel = await _context.TblCategories.Where(x => x.FldId == (item.FldAccessChannel ?? 0)).FirstOrDefaultAsync();
                TblRoute? route = await _context.TblRoutes.Where(x => x.FldRouteId == item.FldRouteId).FirstOrDefaultAsync();

                item.FldWorkingArea = warea;
                item.FldAdminArea = adminArea;
                item.FldCategory = category;
                item.FldAccessChannel = accessChannel.FldId;
                item.FldRoute = route;
                item.FldIsActive = false;

                TblCustomer? originalItem = await _context.TblCustomers.Where(x => x.FldCustomerId == item.FldCustomerId).FirstOrDefaultAsync();
                if (originalItem != null)
                {
                    HtblCustomer hcustomer = new HtblCustomer();
                    _mapper.Map(originalItem, hcustomer);
                    hcustomer.FldServiceTime = 0;
                    hcustomer.FldUpdateUserId = callerUser.FldUserId;
                    hcustomer.FldCreateDate = DateTime.Now; 
                    await _context.HtblCustomers.AddAsync(hcustomer);
                    await _context.SaveChangesAsync();
                    item.FldLastUpdateDate = DateTime.Now;
                    item.FldUpdateUserId = callerUser.FldUserId;


                    _context.TblCustomers.Update(item);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    item.FldUpdateUserId = callerUser.FldUserId;
                    item.FldCreateEmployeeId = callerUser.FldUserId;

                    await _context.TblCustomers.AddAsync(item);
                    await _context.SaveChangesAsync();

                    if (item.FldCustomerCode == "new")
                    {
                        item.FldCustomerCode = item.FldCustomerId.ToString();
                        _context.TblCustomers.Update(item);
                        await _context.SaveChangesAsync();
                    }

                }
                TblRoute newSalesman = await _context.TblRoutes.Where(x => x.FldRouteId == (item.FldRouteId ?? 0)).FirstOrDefaultAsync();
                TblRoute previousSalesman = await _context.TblRoutes.Where(x => x.FldRouteId == (item.FldRouteId ?? 0)).FirstOrDefaultAsync();

                if (newSalesman != null && previousSalesman != null && newSalesman.FldRouteId != previousSalesman.FldRouteId)
                {
                    newSalesman.FldCurrentBalance += item.FldCurrentBalance;
                    previousSalesman.FldCurrentBalance -= item.FldCurrentBalance;

                    _context.TblRoutes.Update(newSalesman);
                    await _context.SaveChangesAsync();
                    _context.TblRoutes.Update(previousSalesman);
                    await _context.SaveChangesAsync();
                }
                else if (newSalesman != null && previousSalesman == null)
                {
                    newSalesman.FldCurrentBalance += item.FldCurrentBalance;
                    _context.TblRoutes.Update(newSalesman);
                    await _context.SaveChangesAsync();
                }
                else if (newSalesman == null && previousSalesman != null)
                {
                    previousSalesman.FldCurrentBalance -= item.FldCurrentBalance;
                    _context.TblRoutes.Update(previousSalesman);
                    await _context.SaveChangesAsync();
                }


                result.SetResult(true, item.FldCustomerId, item.FldCreateDate, "Looks up a localized string similar to Data has been processed successfully!.");

                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {model.AccessToken}");
                return Json(result);

            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {model.AccessToken}");
                return Json(result);
            }

        }

        [HttpGet]
        [Route("removeCustomer")]
        public async Task<ActionResult> RemoveCustomer(string accessToken, long id)
        {
            ResponseStatusModel result = new ResponseStatusModel();

            try
            {
                TblUser user = Common.GetUserFromAccessToken(accessToken, _context, out string clientcode);
                if (user == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                    return Json(result);
                }

                TblUserPrivilege? userPrivilege = await _context.TblUserPrivileges.Where(x => x.FldUserId == user.FldUserId && x.FldPrivilegeId == 26).FirstOrDefaultAsync();
                if (userPrivilege == null)
                {
                    result.SetResult(false, _localizer["MsgGeneralInvalidToken"].Value);
                    LogsServices.LogError($"IDM | CAA | RemoveCustomer Trial from UnAuthorized User AccessToken{accessToken}");
                    return Json(result);
                }

                //Data Integrity Check
                // Prevent Deletion if this item is used in: customers

                List<TblCustomerVisit> visitItems = await _context.TblCustomerVisits
                                                                    .Where(x => x.FldCustomerId == id)
                                                                    .Skip(0)
                                                                    .Take(1)
                                                                    .ToListAsync();

                List<TblPlanItem> planItems = await _context.TblPlanItems
                                                                   .Where(x => x.FldCustomerId == id)
                                                                   .Skip(0)
                                                                   .Take(1)
                                                                   .ToListAsync();

                if ((planItems != null && planItems.Count > 0) || (visitItems != null && visitItems.Count > 0))
                {
                    result.SetResult(false, " Looks up a localized string similar to This item cannot be removed as it is linked with other items!", IDVErrorCodes.Failure);
                    LogsServices.LogError($"IDM | Config | AccessToken {{1}} Data Integration Error in Remove Customer  {accessToken}");
                    return Json(result);
                }

                TblCustomer? item = await _context.TblCustomers.Where(x => x.FldCustomerId == id).FirstOrDefaultAsync();
                if ((item == null))
                {
                    result.SetResult(false, " Looks up a localized string similar to This item cannot be removed as it is linked with other items!", IDVErrorCodes.Failure);
                    LogsServices.LogError($"IDM | Config | AccessToken {{1}} Data Integration Error in Remove Customer  {accessToken}");
                    return Json(result);
                }
                item!.FldUpdateUserId = user.FldUserId;
                item.FldIsDeleted = true;
                item.FldDeleteDate = DateTime.Now;
                //DataRepository.Connections[clientcode].Provider.CustomerProvider.Update(item);
                _context.TblCustomers.Update(item);
                await _context.SaveChangesAsync();
                result.SetResult(true, "Looks up a localized string similar to Item was removed successfully!");
                return Json(result);
            }
            catch (Exception ex)
            {
                result.SetResult(false, _localizer["MsgGeneralServerError"].Value);
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken {accessToken}");
                return Json(result);
            }

        }
    }
}