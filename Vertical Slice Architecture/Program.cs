using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Vertical_Slice_Architecture;
using Vertical_Slice_Architecture.Features.FetchData;
using Vertical_Slice_Architecture.Features.NumberDisplay;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<INumberController, NumberController>();
builder.Services.AddScoped<IFetchWeatherData, FetchWeatherData>();

await builder.Build().RunAsync();
