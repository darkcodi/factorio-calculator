using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FactorioCalculator;using FactorioCalculator.PreDefinedSets;
using FactorioCalculator.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

new SatisfactoryFactoriesSet().ApplyTo(BasePlan.Instance);
builder.Services.AddSingleton(BasePlan.Instance);

await builder.Build().RunAsync();