using BlazorApp.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    // "partial" allows you to merge 2 classes together
    public partial class FetchData
    {
        protected WeatherForecast[]? forecasts;

        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
