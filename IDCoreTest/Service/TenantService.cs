using IDCoreTest.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace IDCoreTest;

public class TenantService : ITenantService
{
    private readonly TenantSettings _tenantSettings;
    private HttpContext? _httpContext;
    private Tenant? _currentTenant;
    private SubmitResponseStatusModel result = new SubmitResponseStatusModel();

    public TenantService(IHttpContextAccessor contextAccessor, IOptions<TenantSettings> tenantSettings)
    {
        _httpContext = contextAccessor.HttpContext;
        _tenantSettings = tenantSettings.Value;

        if(_httpContext is not null)
        {
            if(_httpContext.Items.ContainsKey("accessToken" )  )
            {
                var tenantId= _httpContext.Items["accessToken"]!.ToString();
                SetCurrentTenant(tenantId!);
            }
            else
            {
                 LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken  ");
                _httpContext.Response.StatusCode = 401; 
                throw new Exception("Looks up a localized string similar to Invalid Access Token.");
            }
        }
    }

    public string? GetConnectionString()
    {
        var currentConnectionString = _currentTenant is null 
            ? _tenantSettings.Defaults.ConnectionString
            : _currentTenant.ConnectionString;

        return currentConnectionString;
    }

    public Tenant? GetCurrentTenant()
    {
        return _currentTenant;
    }

    public string? GetDatabaseProvider()
    {
        return _tenantSettings.Defaults.DBProvider;
    }

    private void SetCurrentTenant(string tenantId)
    {
        _currentTenant = _tenantSettings.Tenants.FirstOrDefault(t => t.TId == tenantId);

        if (_httpContext is not null)
        {
            if (_currentTenant is null)
            {
                result.SetResult(false, "Looks up a localized string similar to Invalid Access Token.");
                LogsServices.LogError($"IDM | CAA | GetCustomersByWorkingArea for Invalid AccessToken  ");
                _httpContext.Response.StatusCode = 401;
                throw new Exception("Looks up a localized string similar to Invalid Access Token.");

            }
        }

        if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
        {
            _currentTenant.ConnectionString = _tenantSettings.Defaults.ConnectionString;
        }
    }
}