using System.Text.Json;

namespace net_weather_api.Services
{
    public class OpenWeatherService
    {
        private HttpClient _client;
        private IConfiguration _config;
        public OpenWeatherService(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }
        public async Task<T> Get<T>(string endpoint, string query)
        {
            HttpResponseMessage response = await _client.GetAsync(
                $"{endpoint}?{query}&appid={_config["OPENWEATHER:API_KEY"]}"
            );

            response.EnsureSuccessStatusCode();

            string responseData = await response.Content.ReadAsStringAsync();

            T result = JsonSerializer.Deserialize<T>(responseData);

            return result;
        }
    }
}