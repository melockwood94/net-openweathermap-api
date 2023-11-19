using net_weather_api.Services;

namespace net_weather_api.Models
{
    public class GeocodeRepository
    {
        private OpenWeatherService _service;
        public GeocodeRepository(OpenWeatherService service)
        {
            _service = service;
        }
        public async Task<GeocodeResponse> GetGeocode(GeocodeRequest request)
        {
            List<GeocodeResponseItem> geoData = await _service.Get<List<GeocodeResponseItem>>(
                "http://api.openweathermap.org/geo/1.0/direct", 
                $"q={request.CityName},{request.StateCode},{request.CountryCode}"
            );

            GeocodeResponse response = new GeocodeResponse{
                Results = geoData
            };

            return response;
        }
    }
}