using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimpleWeather
{
    //.json weather deserialization classes by key = value
    public class WeatherJsonReader
    {
        [JsonProperty("name")]
        public string CityName { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("main")]
        public WeatherJsonReaderMain Main { get; set; }

        [JsonProperty("clouds")]
        public WeatherJsonReaderClouds Clouds { get; set; }

        [JsonProperty("wind")]
        public WeatherJsonReaderWind Wind { get; set; }

        [JsonProperty("weather")]
        public List<WeatherJsonReaderConditions> Conditions { get; set; }

    }

    public class WeatherJsonReaderMain
    {
        [JsonProperty("temp")]
        public float temperature { get; set; }

        [JsonProperty("feels_like")]
        public float FellsTemperature { get; set; }

        [JsonProperty("temp_min")]
        public float MinTemperature { get; set; }

        [JsonProperty("temp_max")]
        public float MaxTemperature { get; set; }

        [JsonProperty("pressure")]
        public float Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }

    public class WeatherJsonReaderClouds
    {
        [JsonProperty("all")]
        public int Cloudy { get; set; }
    }

    public class WeatherJsonReaderWind
    {
        [JsonProperty("speed")]
        public float SpeedWind { get; set; }
    }

    public class WeatherJsonReaderConditions
    {
        [JsonProperty("description")]
        public string WeatherConditions { get; set; }

        [JsonProperty("icon")]
        public string IconConditions { get; set; }
    }
}
