using IDCoreTest.Models;
using System.Data;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Transactions;
using Microsoft.Extensions.Logging;
using IDCoreTest.Helpers;
using IDCoreTest.ContextDB;
using IDCoreTest.Controllers;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Linq.Expressions;

namespace IDCoreTest 
{
    public class Common
    { 
        public static string PhotoFolderURL = "http://localhost/id.reports/";
        public static Uri PhotosURI = new Uri(PhotoFolderURL);
        public  static int CompanyCodeLength = 5;
        //public Common(AppContextDB context )
        //{
        //    _context = context; 
        //}
        public static TblUser GetUserFromAccessToken(string accessToken, AppContextDB _context, out string clientCode)
        {
            clientCode = "";
            try
            {
                clientCode = accessToken.Substring(0, CompanyCodeLength);
               // NLog.GlobalDiagnosticsContext.Set("ClientCode", clientCode);
                if (accessToken.Contains("EZSLR"))
                { 
                    return new TblUser { FldBranchId = null, FldUserName = "SuperAdmin", FldUserId = -1 };
                }
                long sessionId = long.Parse(accessToken.Substring(CompanyCodeLength));
 
                TblSession session = _context.TblSessions?.Where(x=>x.FldSessionId == sessionId)?.SingleOrDefault()!;
                if (session != null && session.FldStatus == 1)
                {
                    TblUser user = _context.TblUsers?.Where(x => x.FldUserId == session.FldUserId)?.SingleOrDefault()!;
                    if (user != null && !user.FldIsDeleted)
                        return user; 
                } 
            }
            catch (Exception ex)
            {
                // logger.Error(ex, "IDM | Exception in GetUserFromAccessToken {0}", accessToken);
                LogsServices.LogCatchError(ex, "Catch Error:");
            }  
            clientCode = "NA";
            return null;
        }
        public static string[] GetBranchRoutes(string clientcode, AppContextDB _context , long? branchId)
        {

            //query.Append(RouteColumn.FldIsDeleted, Boolean.FalseString);
            List<TblRoute> routes = new List<TblRoute>();
            //0- if no Branches
            if (branchId == null)
            {
                // routes = DataRepository.Connections[clientcode].Provider.RouteProvider.Find(query.GetParameters());
                routes = _context.TblRoutes.Where(p=>!p.FldIsDeleted).ToList();
            }
            else
            { 
                //1- Get Sub-Branches/Departments
                List<TblBranch> childBranches = _context.TblBranches.Where(p=>p.FldParentId==branchId).ToList();
                List<TblBranch> allChildBranches = new List<TblBranch>(childBranches);
             
                foreach (TblBranch item in childBranches)
                {
                    List<TblBranch> gchildList = _context.TblBranches.Where(p => p.FldParentId == item.FldId).ToList();
                    allChildBranches.AddRange(gchildList);
                }

                var q = from branch in allChildBranches
                        select branch.FldId.ToString();

                List<string> branchesIdsList = q.ToList<string>();
                branchesIdsList.Add(branchId.ToString());
                string[] branchesIds = branchesIdsList.ToArray();

                //2- Get routes
             //   query.AppendIn(RouteColumn.FldBranchId, branchesIds);

              //  routes = DataRepository.Connections[clientcode].Provider.RouteProvider.Find(query.GetParameters());
                routes = _context.TblRoutes.Where(p => branchesIds.Contains(p.FldBranchId.ToString()) && !p.FldIsDeleted).ToList();

            }

            var ids = from route in routes
                      select route.FldRouteId.ToString();
            if (routes.Count == 0)
                return new string[] { "0" };
            else
                return ids.ToArray<string>();
        }
        public static T ConvertListToObject<T>(List<T> dataList) where T : new()
        {
            T obj = new T();
            var properties = typeof(T).GetProperties();

            for (int i = 0; i < Math.Min(properties.Length, dataList.Count); i++)
            {
                // You might need to handle type conversion here based on the actual types of your properties
                properties[i].SetValue(obj, Convert.ChangeType(dataList[i], properties[i].PropertyType));
            }

            return obj;
        }

    }

   
    public class CustomerParameterBuilder
    {
        private Expression<Func<TblCustomer, bool>> _filterExpression = x => true; // Start with a default true condition

        public void Append(Expression<Func<TblCustomer, bool>> filter)
        {
            _filterExpression = _filterExpression.AndAlso(filter);
        }

        // Other Append methods...

        public Expression<Func<TblCustomer, bool>> Build()
        {
            return _filterExpression;
        }
    }

    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> AndAlso<T>(
            this Expression<Func<T, bool>> left,
            Expression<Func<T, bool>> right)
        {
            var andAlsoExpression = Expression.AndAlso(
                left.Body,
                right.Body.ReplaceParameter(right.Parameters[0], left.Parameters[0]));

            return Expression.Lambda<Func<T, bool>>(andAlsoExpression, left.Parameters);
        }

        // Extension method to replace parameter in an expression
        public static Expression ReplaceParameter(this Expression expression, ParameterExpression oldParameter, ParameterExpression newParameter)
        {
            return new ParameterReplacer(oldParameter, newParameter).Visit(expression);
        }

        private class ParameterReplacer : ExpressionVisitor
        {
            private readonly ParameterExpression _oldParameter;
            private readonly ParameterExpression _newParameter;

            public ParameterReplacer(ParameterExpression oldParameter, ParameterExpression newParameter)
            {
                _oldParameter = oldParameter;
                _newParameter = newParameter;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return node == _oldParameter ? _newParameter : base.VisitParameter(node);
            }
        }
    }

    public static class Helper
    {
        public static double GetTimeStampFromDateTime(DateTime? value)
        {
             if (value == null)
                return 0;
            return Math.Truncate((value.Value - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds);
        }
    }

}
