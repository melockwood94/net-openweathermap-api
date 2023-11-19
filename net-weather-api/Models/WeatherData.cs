using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace net_weather_api.Models
{
    public class WeatherRequest
    {
        [Required]
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
        [JsonPropertyName("lon")]
        [Required]
        public double Longitude { get; set; }
        [JsonPropertyName("units")]
        public string Units { get; set; } = "imperial";
    }
    public class WeatherResponse
    {
        [JsonPropertyName("coord")]
        public Coordinates? WeatherCoordinates { get; set; }
        [JsonPropertyName("weather")]
        public List<WeatherData>? WeatherData { get; set; }
        [JsonPropertyName("main")]
        public ForecastData? ForecastData { get; set; }
        [JsonPropertyName("visibility")]
        public int? Visibility { get; set; }
        [JsonPropertyName("wind")]
        public WindData? WindData { get; set; }
        [JsonPropertyName("clouds")]
        public CloudData? CloudData { get; set; }
    }
    public class Coordinates
    {
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
    }
    public class WeatherData
    {
        [JsonPropertyName("id")]
        public int? WeatherId { get; set; }
        [JsonPropertyName("main")]
        public string Summary { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }
    public class ForecastData
    {
        [JsonPropertyName("temp")]
        public double? Temperature { get; set; }
        [JsonPropertyName("feels_like")]
        public double? TemperatureFeelsLike { get; set; }
        [JsonPropertyName("temp_min")]
        public double? TemperatureMinimum { get; set; }
        [JsonPropertyName("temp_max")]
        public double? TemperatureMaximum { get; set; }
        [JsonPropertyName("pressure")]
        public int? Pressure { get; set; }
        [JsonPropertyName("humidity")]
        public int? Humidity { get; set; }
    }
    public class WindData
    {
        [JsonPropertyName("speed")]
        public double? WindSpeed { get; set; }
        [JsonPropertyName("deg")]
        public int? WindDirectionDegree { get; set; }
        [JsonPropertyName("gust")]
        public double? WindGustSpeed { get; set; }
    }
    public class CloudData
    {
        [JsonPropertyName("all")]
        public int? Cloudiness { get; set; }
    }
    public class RainData
    {
        [JsonPropertyName("1h")]
        public int? RainVolumeOneHour { get; set; }
        [JsonPropertyName("3h")]
        public int? RainVolumeThreeHour { get; set; }
    }
    public class SnowData
    {
        [JsonPropertyName("1h")]
        public int? SnowVolumeOneHour { get; set; }
        [JsonPropertyName("3h")]
        public int? SnowVolumeThreeHour { get; set; }
    }
}