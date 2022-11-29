using Entities;

namespace Vertical_Slice_Architecture.Features.FetchData;

public interface IFetchWeatherData
{
    WeatherForecast[]? Forecasts { get; }
    Task GetWeatherAsync();
}