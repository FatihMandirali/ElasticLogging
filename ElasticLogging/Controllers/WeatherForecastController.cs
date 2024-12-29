using ElasticLogging.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ElasticLogging.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        
        _logger.LogInformation("{@LogModel}", new CustomLogModel
        {
            Level = "Information",
            Message = "fatih mandıralı",
            Timestamp = DateTime.UtcNow,
            UserId = "userıd:ftm",
        });
        return [];
    }
}