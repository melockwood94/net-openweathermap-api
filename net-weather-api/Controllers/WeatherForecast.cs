using Microsoft.AspNetCore.Mvc;
using net_weather_api.Models;

namespace net_weather_api.Controllers
{
    [ApiController]
    [Route("/api/v1/weather/")]
    public class WeatherForecastController : ControllerBase
    {
        private WeatherRepository _repository;
        public WeatherForecastController(WeatherRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("forecast/city")]
        public async Task<WeatherResponse> GetForecastByCity([FromQuery]GeocodeRequest GeoData)
        {
            WeatherResponse WeatherData = await _repository.GetForecastByGeocode(GeoData);

            return WeatherData;
        }
    }
}