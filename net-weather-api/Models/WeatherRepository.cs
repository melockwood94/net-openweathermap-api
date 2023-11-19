using net_weather_api.Services;

namespace net_weather_api.Models
{
    public class WeatherRepository
    {
        private OpenWeatherService _service;
        private GeocodeRepository _repository;
        public WeatherRepository(OpenWeatherService service, GeocodeRepository repository)
        {
            _service = service;
            _repository = repository;
        }
        public async Task<WeatherResponse> GetForecastByGeocode(GeocodeRequest GeocodeRequest)
        {
            GeocodeResponse GeoResponse = await _repository.GetGeocode(GeocodeRequest);
            WeatherResponse response = await _service.Get<WeatherResponse>(
                "https://api.openweathermap.org/data/2.5/weather",
                $"lat={GeoResponse.Results[0].Latitude}&lon={GeoResponse.Results[0].Longitude}"
            );

            return response;
        }
    }
}