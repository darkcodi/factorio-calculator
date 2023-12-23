using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FactorioCalculator;
using FactorioCalculator.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var catalog = new Catalog();
catalog.AddFactory("Iron Plate", [new("Iron Ore", 1)], [new("Iron Plate", 1)]);
catalog.AddFactory("Copper Plate", [new("Copper Ore", 1)], [new("Copper Plate", 1)]);
catalog.AddFactory("Steel Plate", [new("Iron Plate", 5)], [new("Steel Plate", 1)]);
catalog.AddFactory("Iron Gear Wheel", [new("Iron Plate", 2)], [new("Iron Gear Wheel", 1)]);
catalog.AddFactory("Copper Cable", [new("Copper Plate", 1)], [new("Copper Cable", 2)]);
catalog.AddFactory("Electronic Circuit", [new("Iron Plate", 1), new("Copper Cable", 3)], [new("Electronic Circuit", 1)]);
catalog.AddFactory("Advanced Circuit", [new("Electronic Circuit", 2), new("Plastic Bar", 2), new("Copper Cable", 4)], [new("Advanced Circuit", 1)]);

builder.Services.AddSingleton(catalog);

await builder.Build().RunAsync();