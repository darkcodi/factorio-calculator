using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FactorioCalculator;
using FactorioCalculator.Models;
using FactorioCalculator.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var catalog = new BasePlan();
catalog.AddFactory(new Factory("Iron Plate") { Inputs = [new("Iron Ore", 1)], Outputs = [new("Iron Plate", 1)] });
catalog.AddFactory(new Factory("Copper Plate") { Inputs = [new("Copper Ore", 1)], Outputs = [new("Copper Plate", 1)] });
catalog.AddFactory(new Factory("Iron Gear Wheel") { Inputs = [new("Iron Plate", 2)], Outputs = [new("Iron Gear Wheel", 1)] });
catalog.AddFactory(new Factory("Electronic Circuit") { Inputs = [new("Iron Plate", 1), new("Copper Plate", 3)], Outputs = [new("Electronic Circuit", 1)] });
catalog.AddFactory(new Factory("Copper Cable") { Inputs = [new("Copper Plate", 1)], Outputs = [new("Copper Cable", 2)] });
catalog.AddFactory(new Factory("Transport Belt") { Inputs = [new("Iron Plate", 1), new("Iron Gear Wheel", 1)], Outputs = [new("Transport Belt", 2)] });
catalog.AddFactory(new Factory("Inserter") { Inputs = [new("Iron Plate", 1), new("Iron Gear Wheel", 1), new("Electronic Circuit", 1)], Outputs = [new("Inserter", 1)] });
catalog.AddFactory(new Factory("Science Pack 1") { Inputs = [new("Copper Plate", 1), new("Iron Gear Wheel", 1)], Outputs = [new("Science Pack 1", 1)] });
catalog.AddFactory(new Factory("Science Pack 2") { Inputs = [new("Inserter", 1), new("Transport Belt", 1)], Outputs = [new("Science Pack 2", 1)] });
catalog.AddFactory(new Factory("Science Pack 3") { Inputs = [new("Science Pack 1", 1), new("Science Pack 2", 1), new("Electronic Circuit", 1)], Outputs = [new("Science Pack 3", 1)] });
catalog.AddFactory(new Factory("Military Science Pack") { Inputs = [new("Piercing Round Magazine", 1), new("Grenade", 1)], Outputs = [new("Military Science Pack", 2)] });
catalog.AddFactory(new Factory("Piercing Round Magazine") { Inputs = [new("Copper Plate", 5), new("Steel Plate", 1)], Outputs = [new("Piercing Round Magazine", 1)] });
catalog.AddFactory(new Factory("Grenade") { Inputs = [new("Iron Plate", 5), new("Coal", 10)], Outputs = [new("Grenade", 1)] });
catalog.AddFactory(new Factory("Steel Plate") { Inputs = [new("Iron Plate", 5)], Outputs = [new("Steel Plate", 1)] });
catalog.AddFactory(new Factory("Stone Furnace") { Inputs = [new("Stone", 5)], Outputs = [new("Stone Furnace", 1)] });
catalog.AddFactory(new Factory("Stone Brick") { Inputs = [new("Stone", 2)], Outputs = [new("Stone Brick", 1)] });
catalog.AddFactory(new Factory("Stone Wall") { Inputs = [new("Stone Brick", 5)], Outputs = [new("Stone Wall", 1)] });
catalog.AddFactory(new Factory("Assembling Machine 1") { Inputs = [new("Iron Plate", 9), new("Iron Gear Wheel", 5), new("Electronic Circuit", 3)], Outputs = [new("Assembling Machine 1", 1)] });
catalog.AddFactory(new Factory("Assembling Machine 2") { Inputs = [new("Iron Plate", 9), new("Iron Gear Wheel", 5), new("Electronic Circuit", 3), new("Assembling Machine 1", 1)], Outputs = [new("Assembling Machine 2", 1)] });

builder.Services.AddSingleton(catalog);

await builder.Build().RunAsync();