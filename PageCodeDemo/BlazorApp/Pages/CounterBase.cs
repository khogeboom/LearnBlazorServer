using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public class CounterBase : ComponentBase
    {
        // need to be "protected" so they can be used in Counter.razor
        protected int currentCount = 0;

        [Inject]
        public ILogger<CounterBase> Log { get; set; }

        protected void IncrementCount()
        {
            currentCount+=2;
            Log.LogInformation("The new value is {CounterValue}", currentCount);
        }
    }
}
