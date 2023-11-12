using IDCoreTest.ContextDB;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Serilog;
using System.Globalization;
using System.Text.Json.Serialization;
 
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
 using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
 var builder = WebApplication.CreateBuilder(args);



builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped<ITenantService, TenantService>();
builder.Services.Configure<TenantSettings>(builder.Configuration.GetSection(nameof(TenantSettings)));

TenantSettings options = new();
builder.Configuration.GetSection(nameof(TenantSettings)).Bind(options);

var defaultDbProvider = options.Defaults.DBProvider;

if (defaultDbProvider.ToLower() == "mssql")
{

    builder.Services.AddDbContext<AppContextDB>(m => m.UseSqlServer());
}

foreach (var tenant in options.Tenants)
{
    var connectionString = tenant.ConnectionString ?? options.Defaults.ConnectionString;

    using var scope = builder.Services.BuildServiceProvider().CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<AppContextDB>();

    dbContext.Database.SetConnectionString(connectionString);

    if (dbContext.Database.GetPendingMigrations().Any())
    {
        dbContext.Database.Migrate();
    }
}
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    List<CultureInfo> supportedCultures = new List<CultureInfo>
                {
                      new CultureInfo("EN"),
                    new CultureInfo("AR"),
                };
    options.DefaultRequestCulture = new RequestCulture("EN");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});


builder.Services.AddAutoMapper(typeof(MapperProfile));
// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Host.UseSerilog((hostContext, services, configuration) => {
    configuration.ReadFrom.Configuration(hostContext.Configuration)
  .Enrich.FromLogContext();
}); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();
app.UseTenancyMiddleware();

app.MapControllers();

app.Run();
