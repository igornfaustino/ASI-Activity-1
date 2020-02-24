using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly Dictionary<String, WeatherForecast> cities = new Dictionary<string, WeatherForecast>
        {
            {"5300250",  new WeatherForecast {
                Date = DateTime.Parse("2020-02-25T16:41:48.1383231+00:00"),
                TemperatureC = 0,
                Summary = "Freezing"
            }},
            {"5300251",  new WeatherForecast {
                Date = DateTime.Parse("2020-02-25T16:41:48.1383231+00:00"),
                TemperatureC = 4,
                Summary = "Bracing"
            }},
            {"5300252",  new WeatherForecast {
                Date = DateTime.Parse("2020-02-25T16:41:48.1383231+00:00"),
                TemperatureC = 21,
                Summary = "Chilly"
            }},
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public WeatherForecast Get()
        {
            return new WeatherForecast
            {
                Date = DateTime.Parse("2020-02-25T16:41:48.1383231+00:00"),
                TemperatureC = 21,
                Summary = "Sunny"
            };
        }

        [HttpGet("{zip}")]
        public WeatherForecast GetByCep(String zip)
        {
            return cities[zip];
        }
    }
}
