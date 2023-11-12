namespace IDCoreTest;

public interface ITenantService
{
    string? GetDatabaseProvider();
    string? GetConnectionString();
    Tenant? GetCurrentTenant();
}