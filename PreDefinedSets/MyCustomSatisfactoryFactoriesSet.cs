using FactorioCalculator.Models;
using FactorioCalculator.Services;

namespace FactorioCalculator.PreDefinedSets;

public class MyCustomSatisfactoryFactoriesSet : IFactoriesSet
{
    private readonly IFactoriesSet _baseSet = new SatisfactoryFactoriesSet();

    public void ApplyTo(BasePlan plan)
    {
        plan.AddFactory(new Factory("Завод СтальТруб-160") { Inputs = [new ResourceAmount("Iron Ore", 240), new ResourceAmount("Coal Ore", 240)], Outputs = [new ResourceAmount("Steel Pipe", 160)] });
        plan.AddFactory(new Factory("Завод Сталевик-60") { Inputs = [new ResourceAmount("Iron Ore", 240), new ResourceAmount("Coal Ore", 240)], Outputs = [new ResourceAmount("Steel Beam", 60)] });
        plan.AddFactory(new Factory("Завод Роторчик-30") { Inputs = [new ResourceAmount("Copper Sheet", 60), new ResourceAmount("Screw", 520)], Outputs = [new ResourceAmount("Rotor", 30)] });
        plan.AddFactory(new Factory("Завод Рама-8") { Inputs = [new ResourceAmount("Reinforced Iron Plate", 12), new ResourceAmount("Iron Rod", 48)], Outputs = [new ResourceAmount("Modular Frame", 8)] });
        plan.AddFactory(new Factory("Завод МоторСіч-15") { Inputs = [new ResourceAmount("Rotor", 30), new ResourceAmount("Stator", 30)], Outputs = [new ResourceAmount("Motor", 15)] });
        plan.AddFactory(new Factory("Завод МетСтриж-60") { Inputs = [new ResourceAmount("Iron Ore", 60)], Outputs = [new ResourceAmount("Iron Rod", 60)] });
        plan.AddFactory(new Factory("Завод МетПлит-80") { Inputs = [new ResourceAmount("Iron Ore", 120)], Outputs = [new ResourceAmount("Iron Plate", 80)] });
        plan.AddFactory(new Factory("Завод МегаБолт-240") { Inputs = [new ResourceAmount("Iron Rod", 60)], Outputs = [new ResourceAmount("Screw", 240)] });
        plan.AddFactory(new Factory("Завод МідЛист-60") { Inputs = [new ResourceAmount("Copper Ore", 120)], Outputs = [new ResourceAmount("Copper Sheet", 60)] });
        plan.AddFactory(new Factory("Завод Кабель-120") { Inputs = [new ResourceAmount("Wire", 240)], Outputs = [new ResourceAmount("Cable", 120)] });
        plan.AddFactory(new Factory("Завод Дріт-120") { Inputs = [new ResourceAmount("Copper Ore", 60)], Outputs = [new ResourceAmount("Wire", 120)] });
        plan.AddFactory(new Factory("Завод АрмЗалПлит-20") { Inputs = [new ResourceAmount("Iron Plate", 120), new ResourceAmount("Screw", 240)], Outputs = [new ResourceAmount("Reinforced Iron Plate", 20)] });
        plan.AddFactory(new Factory("Завод Бетон-80") { Inputs = [new ResourceAmount("Limestone", 240)], Outputs = [new ResourceAmount("Concrete", 80)] });
        _baseSet.ApplyTo(plan);
    }
}