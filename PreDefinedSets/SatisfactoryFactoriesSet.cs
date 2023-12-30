using FactorioCalculator.Models;
using FactorioCalculator.Services;

namespace FactorioCalculator.PreDefinedSets;

public class SatisfactoryFactoriesSet : IFactoriesSet
{
    public void ApplyTo(BasePlan plan)
    {
        // Add some factories from the Satisfactory game
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Iron Ore)") { Outputs = [new ResourceAmount("Iron Ore", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Copper Ore)") { Outputs = [new ResourceAmount("Copper Ore", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Caterium Ore)") { Outputs = [new ResourceAmount("Caterium Ore", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Coal Ore)") { Outputs = [new ResourceAmount("Coal Ore", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Limestone Ore)") { Outputs = [new ResourceAmount("Limestone", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Sulfur Ore)") { Outputs = [new ResourceAmount("Sulfur", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Uranium Ore)") { Outputs = [new ResourceAmount("Uranium", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Bauxite Ore)") { Outputs = [new ResourceAmount("Bauxite", 240)] });
        plan.AddFactory(new Factory("Miner Mk.2 - Pure (Quartz Ore)") { Outputs = [new ResourceAmount("Raw Quartz", 240)] });
        plan.AddFactory(new Factory("Water Extractor") { Outputs = [new ResourceAmount("Water", 120)] });
        plan.AddFactory(new Factory("Oil Extractor") { Outputs = [new ResourceAmount("Crude Oil", 120)] });
        plan.AddFactory(new Factory("Coal Generator") { Inputs = [new ResourceAmount("Coal Ore", 15), new ResourceAmount("Water", 45)], Outputs = [new ResourceAmount("Power", 75)] });
        plan.AddFactory(new Factory("Nuclear Plant (Uranium)") { Inputs = [new ResourceAmount("Uranium Fuel Rod", 0.2), new ResourceAmount("Water", 240)], Outputs = [new ResourceAmount("Power", 2500), new ResourceAmount("Nuclear Waste", 10)] });
        plan.AddFactory(new Factory("Smelter (Iron Ingot)") { Inputs = [new ResourceAmount("Iron Ore", 30)], Outputs = [new ResourceAmount("Iron Ingot", 30)] });
        plan.AddFactory(new Factory("Smelter (Copper Ingot)") { Inputs = [new ResourceAmount("Copper Ore", 30)], Outputs = [new ResourceAmount("Copper Ingot", 30)] });
        plan.AddFactory(new Factory("Smelter (Caterium Ingot)") { Inputs = [new ResourceAmount("Caterium Ore", 45)], Outputs = [new ResourceAmount("Caterium Ingot", 15)] });
        plan.AddFactory(new Factory("Foundry (Steel Ingot)") { Inputs = [new ResourceAmount("Iron Ore", 45), new ResourceAmount("Coal Ore", 45)], Outputs = [new ResourceAmount("Steel Ingot", 45)] });
        plan.AddFactory(new Factory("Foundry (Aluminium Ingot)") { Inputs = [new ResourceAmount("Aluminium Scrap", 90), new ResourceAmount("Silica", 75)], Outputs = [new ResourceAmount("Aluminium Ingot", 60)] });
        plan.AddFactory(new Factory("Constructor (Empty Canister)") { Inputs = [new ResourceAmount("Plastic", 30)], Outputs = [new ResourceAmount("Empty Canister", 60)] });
        plan.AddFactory(new Factory("Constructor (Empty Fluid Tank)") { Inputs = [new ResourceAmount("Aluminium Ingot", 60)], Outputs = [new ResourceAmount("Empty Fluid Tank", 60)] });
        plan.AddFactory(new Factory("Constructor (Iron Plate)") { Inputs = [new ResourceAmount("Iron Ingot", 30)], Outputs = [new ResourceAmount("Iron Plate", 20)] });
        plan.AddFactory(new Factory("Constructor (Iron Rod)") { Inputs = [new ResourceAmount("Iron Ingot", 15)], Outputs = [new ResourceAmount("Iron Rod", 15)] });
        plan.AddFactory(new Factory("Constructor (Screw)") { Inputs = [new ResourceAmount("Iron Rod", 10)], Outputs = [new ResourceAmount("Screw", 40)] });
        plan.AddFactory(new Factory("Constructor (Copper Sheet)") { Inputs = [new ResourceAmount("Copper Ingot", 20)], Outputs = [new ResourceAmount("Copper Sheet", 10)] });
        plan.AddFactory(new Factory("Constructor (Steel Beam)") { Inputs = [new ResourceAmount("Steel Ingot", 60)], Outputs = [new ResourceAmount("Steel Beam", 15)] });
        plan.AddFactory(new Factory("Constructor (Steel Pipe)") { Inputs = [new ResourceAmount("Steel Ingot", 30)], Outputs = [new ResourceAmount("Steel Pipe", 20)] });
        plan.AddFactory(new Factory("Constructor (Aluminium Casing)") { Inputs = [new ResourceAmount("Aluminium Ingot", 90)], Outputs = [new ResourceAmount("Aluminium Casing", 60)] });
        plan.AddFactory(new Factory("Constructor (Concrete)") { Inputs = [new ResourceAmount("Limestone", 45)], Outputs = [new ResourceAmount("Concrete", 15)] });
        plan.AddFactory(new Factory("Constructor (Quartz Crystal)") { Inputs = [new ResourceAmount("Raw Quartz", 37.5)], Outputs = [new ResourceAmount("Quartz Crystal", 22.5)] });
        plan.AddFactory(new Factory("Constructor (Silica)") { Inputs = [new ResourceAmount("Raw Quartz", 22.5)], Outputs = [new ResourceAmount("Silica", 37.5)] });
        plan.AddFactory(new Factory("Constructor (Wire)") { Inputs = [new ResourceAmount("Copper Ingot", 15)], Outputs = [new ResourceAmount("Wire", 30)] });
        plan.AddFactory(new Factory("Constructor (Cable)") { Inputs = [new ResourceAmount("Wire", 60)], Outputs = [new ResourceAmount("Cable", 30)] });
        plan.AddFactory(new Factory("Constructor (Highspeed Wire)") { Inputs = [new ResourceAmount("Caterium Ingot", 12)], Outputs = [new ResourceAmount("Highspeed Wire", 60)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Reinforced Plate)") { Inputs = [new ResourceAmount("Iron Plate", 30), new ResourceAmount("Screw", 60)], Outputs = [new ResourceAmount("Reinforced Plate", 5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Modular Frame)") { Inputs = [new ResourceAmount("Reinforced Plate", 3), new ResourceAmount("Iron Rod", 12)], Outputs = [new ResourceAmount("Modular Frame", 2)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Industrial Beam)") { Inputs = [new ResourceAmount("Steel Beam", 24), new ResourceAmount("Concrete", 30)], Outputs = [new ResourceAmount("Industrial Beam", 6)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Alclad Sheet)") { Inputs = [new ResourceAmount("Aluminium Ingot", 30), new ResourceAmount("Copper Ingot", 10)], Outputs = [new ResourceAmount("Alclad Sheet", 30)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Rotor)") { Inputs = [new ResourceAmount("Iron Rod", 20), new ResourceAmount("Screw", 100)], Outputs = [new ResourceAmount("Rotor", 4)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Rotor-Alt)") { Inputs = [new ResourceAmount("Copper Sheet", 22.5), new ResourceAmount("Screw", 195)], Outputs = [new ResourceAmount("Rotor", 11.25)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Stator)") { Inputs = [new ResourceAmount("Steel Pipe", 15), new ResourceAmount("Wire", 40)], Outputs = [new ResourceAmount("Stator", 5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Motor)") { Inputs = [new ResourceAmount("Rotor", 10), new ResourceAmount("Stator", 10)], Outputs = [new ResourceAmount("Motor", 5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Heat Sink)") { Inputs = [new ResourceAmount("Alclad Sheet", 37.5), new ResourceAmount("Copper Sheet", 22.5)], Outputs = [new ResourceAmount("Heat Sink", 7.5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (AI Limiter)") { Inputs = [new ResourceAmount("Copper Sheet", 25), new ResourceAmount("Highspeed Wire", 100)], Outputs = [new ResourceAmount("AI Limiter", 5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Circuit Board)") { Inputs = [new ResourceAmount("Copper Sheet", 15), new ResourceAmount("Plastic", 30)], Outputs = [new ResourceAmount("Circuit Board", 7.5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (Control Rod)") { Inputs = [new ResourceAmount("Stator", 6), new ResourceAmount("AI Limiter", 4)], Outputs = [new ResourceAmount("Control Rod", 4)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 1)") { Inputs = [new ResourceAmount("Reinforced Plate", 2), new ResourceAmount("Rotor", 2)], Outputs = [new ResourceAmount("SE Item 1", 2)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 2)") { Inputs = [new ResourceAmount("Modular Frame", 2.5), new ResourceAmount("Steel Beam", 30)], Outputs = [new ResourceAmount("SE Item 2", 5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 3)") { Inputs = [new ResourceAmount("Stator", 2.5), new ResourceAmount("Cable", 50)], Outputs = [new ResourceAmount("SE Item 3", 2.5)] });
        plan.AddFactory(new Factory("Assembler Mk.1 (SE Item 6)") { Inputs = [new ResourceAmount("SE Item 5", 1.5), new ResourceAmount("Supercomputer", 0.75)], Outputs = [new ResourceAmount("SE Item 6", 0.75)] });
        plan.AddFactory(new Factory("Manufacturer (Uranium Fuel Rod)") { Inputs = [new ResourceAmount("Uranium Cell", 20), new ResourceAmount("Industrial Beam", 1.2), new ResourceAmount("Control Rod", 2)], Outputs = [new ResourceAmount("Uranium Fuel Rod", 0.4)] });
        plan.AddFactory(new Factory("Manufacturer (Turbo Motor)") { Inputs = [new ResourceAmount("Cooling System", 7.5), new ResourceAmount("Radio Control Unit", 3.75), new ResourceAmount("Motor", 7.5), new ResourceAmount("Rubber", 45)], Outputs = [new ResourceAmount("Turbo Motor", 1.875)] });
        plan.AddFactory(new Factory("Manufacturer (Highspeed Connector)") { Inputs = [new ResourceAmount("Highspeed Wire", 210), new ResourceAmount("Cable", 37.5), new ResourceAmount("Circuit Board", 3.75)], Outputs = [new ResourceAmount("Highspeed Connector", 3.75)] });
        plan.AddFactory(new Factory("Manufacturer (Computer)") { Inputs = [new ResourceAmount("Circuit Board", 25), new ResourceAmount("Cable", 22.5), new ResourceAmount("Plastic", 45), new ResourceAmount("Screw", 130)], Outputs = [new ResourceAmount("Computer", 2.5)] });
        plan.AddFactory(new Factory("Manufacturer (Supercomputer)") { Inputs = [new ResourceAmount("Computer", 3.75), new ResourceAmount("AI Limiter", 3.75), new ResourceAmount("Highspeed Connector", 5.625), new ResourceAmount("Plastic", 52.5)], Outputs = [new ResourceAmount("Supercomputer", 1.875)] });
        plan.AddFactory(new Factory("Manufacturer (Crystal Oscillator)") { Inputs = [new ResourceAmount("Quartz Crystal", 18), new ResourceAmount("Cable", 14), new ResourceAmount("Reinforced Plate", 2.5)], Outputs = [new ResourceAmount("Crystal Oscillator", 1)] });
        plan.AddFactory(new Factory("Manufacturer (Radio Control Unit)") { Inputs = [new ResourceAmount("Aluminium Casing", 40), new ResourceAmount("Crystal Oscillator", 1.25), new ResourceAmount("Computer", 1.25)], Outputs = [new ResourceAmount("Radio Control Unit", 2.5)] });
        plan.AddFactory(new Factory("Manufacturer (Heavy Modular Frame)") { Inputs = [new ResourceAmount("Modular Frame", 10), new ResourceAmount("Steel Pipe", 30), new ResourceAmount("Industrial Beam", 10), new ResourceAmount("Screw", 200)], Outputs = [new ResourceAmount("Heavy Modular Frame", 2)] });
        plan.AddFactory(new Factory("Manufacturer (SE Item 4)") { Inputs = [new ResourceAmount("Motor", 2), new ResourceAmount("Rubber", 15), new ResourceAmount("SE Item 1", 2)], Outputs = [new ResourceAmount("SE Item 4", 1)] });
        plan.AddFactory(new Factory("Manufacturer (SE Item 5)") { Inputs = [new ResourceAmount("SE Item 3", 7.5), new ResourceAmount("Circuit Board", 5), new ResourceAmount("Heavy Modular Frame", 1), new ResourceAmount("Computer", 1)], Outputs = [new ResourceAmount("SE Item 5", 1)] });
        plan.AddFactory(new Factory("Manufacturer (SE Item 7)") { Inputs = [new ResourceAmount("SE Item 2", 2.5), new ResourceAmount("Control Rod", 1), new ResourceAmount("Battery", 5)], Outputs = [new ResourceAmount("SE Item 7", 1)] });
        plan.AddFactory(new Factory("Manufacturer (SE Item 8)") { Inputs = [new ResourceAmount("SE Item 4", 2.5), new ResourceAmount("Turbo Motor", 1), new ResourceAmount("Cooling System", 3), new ResourceAmount("Heavy Modular Frame", 1)], Outputs = [new ResourceAmount("SE Item 8", 1)] });
        plan.AddFactory(new Factory("Packager (Packaged Water)") { Inputs = [new ResourceAmount("Water", 60), new ResourceAmount("Empty Canister", 60)], Outputs = [new ResourceAmount("Packaged Water", 60)] });
        plan.AddFactory(new Factory("Packager (Packaged Sulfur Acid)") { Inputs = [new ResourceAmount("Sulfur Acid", 40), new ResourceAmount("Empty Canister", 40)], Outputs = [new ResourceAmount("Packaged Sulfur Acid", 40)] });
        plan.AddFactory(new Factory("Refinery (Plastic)") { Inputs = [new ResourceAmount("Crude Oil", 30)], Outputs = [new ResourceAmount("Plastic", 20), new ResourceAmount("Heavy Oil Residue", 10)] });
        plan.AddFactory(new Factory("Refinery (Rubber)") { Inputs = [new ResourceAmount("Crude Oil", 30)], Outputs = [new ResourceAmount("Rubber", 20), new ResourceAmount("Heavy Oil Residue", 20)] });
        plan.AddFactory(new Factory("Refinery (Liquid Fuel)") { Inputs = [new ResourceAmount("Crude Oil", 60)], Outputs = [new ResourceAmount("Liquid Fuel", 40), new ResourceAmount("Polymer Resin", 30)] });
        plan.AddFactory(new Factory("Refinery (Plastic-Alt)") { Inputs = [new ResourceAmount("Polymer Resin", 60), new ResourceAmount("Water", 20)], Outputs = [new ResourceAmount("Plastic", 20)] });
        plan.AddFactory(new Factory("Refinery (Rubber-Alt)") { Inputs = [new ResourceAmount("Polymer Resin", 40), new ResourceAmount("Water", 40)], Outputs = [new ResourceAmount("Rubber", 20)] });
        plan.AddFactory(new Factory("Refinery (Aluminium Solution)") { Inputs = [new ResourceAmount("Bauxite", 120), new ResourceAmount("Water", 180)], Outputs = [new ResourceAmount("Aluminium Solution", 120), new ResourceAmount("Silica", 50)] });
        plan.AddFactory(new Factory("Refinery (Aluminium Scrap)") { Inputs = [new ResourceAmount("Aluminium Solution", 240), new ResourceAmount("Coal", 120)], Outputs = [new ResourceAmount("Aluminium Scrap", 360), new ResourceAmount("Water", 120)] });
        plan.AddFactory(new Factory("Refinery (Sulfur Acid)") { Inputs = [new ResourceAmount("Sulfur", 50), new ResourceAmount("Water", 50)], Outputs = [new ResourceAmount("Sulfur Acid", 50)] });
        plan.AddFactory(new Factory("Blender (Uranium Cell)") { Inputs = [new ResourceAmount("Uranium", 50), new ResourceAmount("Concrete", 15), new ResourceAmount("Sulfur Acid", 40)], Outputs = [new ResourceAmount("Uranium Cell", 25), new ResourceAmount("Sulfur Acid", 10)] });
        plan.AddFactory(new Factory("Blender (Cooling System)") { Inputs = [new ResourceAmount("Heat Sink", 12), new ResourceAmount("Rubber", 12), new ResourceAmount("Water", 30), new ResourceAmount("Nitrogen Gas", 150)], Outputs = [new ResourceAmount("Cooling System", 6)] });
        plan.AddFactory(new Factory("Blender (Fused Modular Frame)") { Inputs = [new ResourceAmount("Heavy Modular Frame", 1.5), new ResourceAmount("Aluminium Casing", 75), new ResourceAmount("Nitrogen Gas", 37.5)], Outputs = [new ResourceAmount("Fused Modular Frame", 1.5)] });
        plan.AddFactory(new Factory("Blender (Battery)") { Inputs = [new ResourceAmount("Sulfur Acid", 50), new ResourceAmount("Aluminium Solution", 40), new ResourceAmount("Aluminium Casing", 20)], Outputs = [new ResourceAmount("Battery", 20), new ResourceAmount("Water", 30)] });
    }
}