using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FactorioCalculator;using FactorioCalculator.PreDefinedSets;
using FactorioCalculator.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var plan = new BasePlan();
new SatisfactoryFactoriesSet().ApplyTo(plan);
builder.Services.AddSingleton(plan);

await builder.Build().RunAsync();