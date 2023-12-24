using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FactorioCalculator;
using FactorioCalculator.Models;
using FactorioCalculator.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var plan = new BasePlan();

// Add some factories from the Satisfactory game
plan.AddFactory(new Factory("Miner Mk.2 - Pure (Iron Ore)") { Outputs = [new ResourceAmount("Iron Ore", 240)] });
plan.AddFactory(new Factory("Miner Mk.2 - Pure (Copper Ore)") { Outputs = [new ResourceAmount("Copper Ore", 240)] });
plan.AddFactory(new Factory("Miner Mk.2 - Pure (Caterium Ore)") { Outputs = [new ResourceAmount("Caterium Ore", 240)] });
plan.AddFactory(new Factory("Miner Mk.2 - Pure (Coal Ore)") { Outputs = [new ResourceAmount("Coal Ore", 240)] });
plan.AddFactory(new Factory("Miner Mk.2 - Pure (Limestone Ore)") { Outputs = [new ResourceAmount("Limestone", 240)] });
plan.AddFactory(new Factory("Water Extractor") { Outputs = [new ResourceAmount("Water", 120)] });
plan.AddFactory(new Factory("Oil Extractor") { Outputs = [new ResourceAmount("Crude Oil", 120)] });
plan.AddFactory(new Factory("Smelter (Iron Ingot)") { Inputs = [new ResourceAmount("Iron Ore", 30)], Outputs = [new ResourceAmount("Iron Ingot", 30)] });
plan.AddFactory(new Factory("Smelter (Copper Ingot)") { Inputs = [new ResourceAmount("Copper Ore", 30)], Outputs = [new ResourceAmount("Copper Ingot", 30)] });
plan.AddFactory(new Factory("Smelter (Caterium Ingot)") { Inputs = [new ResourceAmount("Caterium Ore", 45)], Outputs = [new ResourceAmount("Caterium Ingot", 15)] });
plan.AddFactory(new Factory("Foundry (Steel Ingot)") { Inputs = [new ResourceAmount("Iron Ore", 45), new ResourceAmount("Coal Ore", 45)], Outputs = [new ResourceAmount("Steel Ingot", 45)] });
plan.AddFactory(new Factory("Constructor (Iron Plate)") { Inputs = [new ResourceAmount("Iron Ingot", 30)], Outputs = [new ResourceAmount("Iron Plate", 20)] });
plan.AddFactory(new Factory("Constructor (Iron Rod)") { Inputs = [new ResourceAmount("Iron Ingot", 15)], Outputs = [new ResourceAmount("Iron Rod", 15)] });
plan.AddFactory(new Factory("Constructor (Screw)") { Inputs = [new ResourceAmount("Iron Rod", 10)], Outputs = [new ResourceAmount("Screw", 40)] });
plan.AddFactory(new Factory("Constructor (Copper Sheet)") { Inputs = [new ResourceAmount("Copper Ingot", 20)], Outputs = [new ResourceAmount("Copper Sheet", 10)] });
plan.AddFactory(new Factory("Constructor (Steel Beam)") { Inputs = [new ResourceAmount("Steel Ingot", 60)], Outputs = [new ResourceAmount("Steel Beam", 15)] });
plan.AddFactory(new Factory("Constructor (Steel Pipe)") { Inputs = [new ResourceAmount("Steel Ingot", 30)], Outputs = [new ResourceAmount("Steel Pipe", 20)] });
plan.AddFactory(new Factory("Constructor (Concrete)") { Inputs = [new ResourceAmount("Limestone", 45)], Outputs = [new ResourceAmount("Concrete", 15)] });
plan.AddFactory(new Factory("Constructor (Wire)") { Inputs = [new ResourceAmount("Copper Ingot", 15)], Outputs = [new ResourceAmount("Wire", 30)] });
plan.AddFactory(new Factory("Constructor (Cable)") { Inputs = [new ResourceAmount("Wire", 60)], Outputs = [new ResourceAmount("Cable", 30)] });
plan.AddFactory(new Factory("Constructor (Highspeed Wire)") { Inputs = [new ResourceAmount("Caterium Ingot", 12)], Outputs = [new ResourceAmount("Highspeed Wire", 60)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Reinforced Iron Plate)") { Inputs = [new ResourceAmount("Iron Plate", 30), new ResourceAmount("Screw", 60)], Outputs = [new ResourceAmount("Reinforced Iron Plate", 5)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Modular Frame)") { Inputs = [new ResourceAmount("Reinforced Iron Plate", 3), new ResourceAmount("Iron Rod", 12)], Outputs = [new ResourceAmount("Modular Frame", 2)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Industrial Beam)") { Inputs = [new ResourceAmount("Steel Beam", 24), new ResourceAmount("Concrete", 30)], Outputs = [new ResourceAmount("Industrial Beam", 6)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Rotor)") { Inputs = [new ResourceAmount("Iron Rod", 20), new ResourceAmount("Screw", 100)], Outputs = [new ResourceAmount("Rotor", 4)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Rotor-Alt)") { Inputs = [new ResourceAmount("Copper Sheet", 22.5), new ResourceAmount("Screw", 195)], Outputs = [new ResourceAmount("Rotor", 11.25)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Stator)") { Inputs = [new ResourceAmount("Steel Pipe", 15), new ResourceAmount("Wire", 40)], Outputs = [new ResourceAmount("Stator", 5)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Motor)") { Inputs = [new ResourceAmount("Rotor", 10), new ResourceAmount("Stator", 10)], Outputs = [new ResourceAmount("Motor", 5)] });
plan.AddFactory(new Factory("Assembler Mk.1 (AI Limiter)") { Inputs = [new ResourceAmount("Copper Sheet", 25), new ResourceAmount("Highspeed Wire", 100)], Outputs = [new ResourceAmount("AI Limiter", 5)] });
plan.AddFactory(new Factory("Assembler Mk.1 (Circuit Board)") { Inputs = [new ResourceAmount("Copper Sheet", 15), new ResourceAmount("Plastic", 30)], Outputs = [new ResourceAmount("Circuit Board", 7.5)] });
plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 1)") { Inputs = [new ResourceAmount("Reinforced Iron Plate", 2), new ResourceAmount("Rotor", 2)], Outputs = [new ResourceAmount("SE Item 1", 2)] });
plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 2)") { Inputs = [new ResourceAmount("Modular Frame", 2.5), new ResourceAmount("Steel Beam", 30)], Outputs = [new ResourceAmount("SE Item 2", 5)] });
plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 3)") { Inputs = [new ResourceAmount("Stator", 2.5), new ResourceAmount("Cable", 50)], Outputs = [new ResourceAmount("SE Item 3", 2.5)] });
plan.AddFactory(new Factory("Manufacturer (Highspeed Connector)") { Inputs = [new ResourceAmount("Highspeed Wire", 210), new ResourceAmount("Cable", 37.5), new ResourceAmount("Circuit Board", 3.75)], Outputs = [new ResourceAmount("Highspeed Connector", 3.75)] });
plan.AddFactory(new Factory("Manufacturer (Computer)") { Inputs = [new ResourceAmount("Circuit Board", 25), new ResourceAmount("Cable", 22.5), new ResourceAmount("Plastic", 45), new ResourceAmount("Screw", 130)], Outputs = [new ResourceAmount("Computer", 2.5)] });
plan.AddFactory(new Factory("Manufacturer (Heavy Modular Frame)") { Inputs = [new ResourceAmount("Modular Frame", 10), new ResourceAmount("Steel Pipe", 30), new ResourceAmount("Industrial Beam", 10), new ResourceAmount("Screw", 200)], Outputs = [new ResourceAmount("Heavy Modular Frame", 2)] });
plan.AddFactory(new Factory("Manufacturer (SE Item 4)") { Inputs = [new ResourceAmount("Motor", 2), new ResourceAmount("Rubber", 15), new ResourceAmount("SE Item 1", 2)], Outputs = [new ResourceAmount("SE Item 4", 1)] });
plan.AddFactory(new Factory("Manufacturer (SE Item 5)") { Inputs = [new ResourceAmount("SE Item 3", 7.5), new ResourceAmount("Circuit Board", 5), new ResourceAmount("Heavy Modular Frame", 1), new ResourceAmount("Computer", 1)], Outputs = [new ResourceAmount("SE Item 5", 1)] });
plan.AddFactory(new Factory("Refinery (Plastic)") { Inputs = [new ResourceAmount("Crude Oil", 30)], Outputs = [new ResourceAmount("Plastic", 20), new ResourceAmount("Heavy Oil Residue", 10)] });
plan.AddFactory(new Factory("Refinery (Rubber)") { Inputs = [new ResourceAmount("Crude Oil", 30)], Outputs = [new ResourceAmount("Rubber", 20), new ResourceAmount("Heavy Oil Residue", 20)] });
plan.AddFactory(new Factory("Refinery (Liquid Fuel)") { Inputs = [new ResourceAmount("Crude Oil", 60)], Outputs = [new ResourceAmount("Liquid Fuel", 40), new ResourceAmount("Polymer Resin", 30)] });
plan.AddFactory(new Factory("Refinery (Plastic-Alt)") { Inputs = [new ResourceAmount("Polymer Resin", 60), new ResourceAmount("Water", 20)], Outputs = [new ResourceAmount("Plastic", 20)] });
plan.AddFactory(new Factory("Refinery (Rubber-Alt)") { Inputs = [new ResourceAmount("Polymer Resin", 40), new ResourceAmount("Water", 40)], Outputs = [new ResourceAmount("Rubber", 20)] });

builder.Services.AddSingleton(plan);

await builder.Build().RunAsync();