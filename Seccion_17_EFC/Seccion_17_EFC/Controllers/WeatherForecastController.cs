using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Seccion_17_EFC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICancionService _cancionService;
        public WeatherForecastController(ICancionService cancionService)
        {
            _cancionService = cancionService;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _cancionService.AddCancion(new Models.Cancion
            {
                Descripcion = "Nueva cancion",
                Duracion = new TimeSpan(0, 4, 25),
                Titulo = "Cancion1"
            });

            var canciones = _cancionService.GetCanciones();
            var cancion = _cancionService.GetCancion(1);
            cancion.Descripcion = "cancion cambiada";
            _cancionService.Update(cancion);
            _cancionService.DeleteCancion(2);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
