using IDCoreTest.ContextDB;
using IDCoreTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDCoreTest.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly AppContextDB _context;
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(AppContextDB context, ILogger<WeatherForecastController> logger)
        {
            _context = context;

            _logger = logger;
        }
       

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}