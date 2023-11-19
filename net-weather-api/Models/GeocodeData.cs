using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace net_weather_api.Models
{
    public class GeocodeRequest
    {
        [Required]
        [JsonPropertyName("city-name")]
        public string CityName { get; set; } = string.Empty;
        [Required]
        [JsonPropertyName("state-code")]
        public string StateCode { get; set; } = string.Empty;
        [Required]
        [JsonPropertyName("country-code")]
        public string CountryCode { get; set; } = string.Empty;
    }

    public class GeocodeResponse
    {
        [JsonPropertyName("0")]
        public List<GeocodeResponseItem>? Results { get; set; }
    }

    public class GeocodeResponseItem
    {
        [JsonPropertyName("name")]
        public string LocationName { get; set; } = string.Empty;
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;
    }
}