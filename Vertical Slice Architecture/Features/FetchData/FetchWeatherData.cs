using System.Net;
using System.Net.Http.Json;
using Entities;



namespace Vertical_Slice_Architecture.Features.FetchData
{
    public class FetchWeatherData : IFetchWeatherData
    {
        public FetchWeatherData(HttpClient client)
        {
            _client = client;
        }

        private readonly HttpClient _client;
        public WeatherForecast[]? Forecasts { get; private set; }

        public async Task GetWeatherAsync()
        {
            Forecasts = await _client.GetFromJsonAsync<WeatherForecast[]>("/sample-data/weather.json");
        }
    }
}
