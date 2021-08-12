using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDc5MjY5QDMxMzkyZTMyMmUzMFlrUmlXbUFnb2tFN0h1ZkxGUjVyRHNXK0VHanM4eDVEVVdPRGIrNGtVam89;NDc5MjcwQDMxMzkyZTMyMmUzMENLY3hxWStnS21kS3NIVSsxQ01Tb1VwOThoQjFjTG5XZnVGM2t2aU41dlE9;NDc5MjcxQDMxMzkyZTMyMmUzMEl3TzVJT3NFT3RLQk1pQ2VMMkRFdGYrTmJ2ay9XZmNNb1ZlTXk4V0JPQkE9;NDc5MjcyQDMxMzkyZTMyMmUzMFk3L05hMXQvTnlHYkhIUWpOREFxMXlZd3FhMzdFYzUxdHB1TEhRR2crWEk9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
