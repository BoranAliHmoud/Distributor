using IDCoreTest.ContextDB;
using IDCoreTest.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IDCoreTest.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class TenancyMiddleware
    {
        private readonly RequestDelegate _next;

        public TenancyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            SubmitResponseStatusModel result = new SubmitResponseStatusModel();
            string requestBody;
            UpsertEntityModel requestData = new UpsertEntityModel();

            if (httpContext.Request.Method == "POST")
            {
                httpContext.Request.EnableBuffering();

                var stream = httpContext.Request.Body;

                using (var reader = new StreamReader(httpContext.Request.Body, encoding: Encoding.UTF8, detectEncodingFromByteOrderMarks: false, leaveOpen: true))
                {
                    requestBody = await reader.ReadToEndAsync();

                    httpContext.Request.Body.Position = 0; 
                }
                if (requestBody == null)
                {
                    result.SetResult(false, "Looks up a localized string similar to Invalid Access Token.");
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken  ");
                    httpContext.Response.StatusCode = 401;
                    return;
                }
                requestData = JsonConvert.DeserializeObject<UpsertEntityModel>(requestBody);
 
            }
            else if (httpContext.Request.Method == "GET")
            {
                var accessToken = httpContext.Request.Query["accessToken"].ToString();
                if (!string.IsNullOrEmpty(accessToken))
                {
                    requestData.AccessToken = accessToken;
                }
                else
                {
                    result.SetResult(false, "Looks up a localized string similar to Invalid Access Token.");
                    LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken  ");
                    httpContext.Response.StatusCode = 401;
                    return;
                }

            }


            if (requestData == null)
            {
                result.SetResult(false, "Looks up a localized string similar to Invalid Access Token.");
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken  ");
                httpContext.Response.StatusCode = 401;
                return ;
            } 

            var clientCode = requestData.AccessToken.Substring(0, 5);
            var Lng = requestData.Lng;
            if (Lng != null)
            {
                httpContext.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Lng)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }

                );
            }
            httpContext.Items.Add("accessToken", clientCode); 
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class TenancyMiddlewareExtensions
    {
        public static IApplicationBuilder UseTenancyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TenancyMiddleware>();
        }
    }
}
