using FactorioCalculator.Models;

namespace FactorioCalculator.Services;

public class Catalog
{
    public List<Factory> Factories { get; set; } = new();

    public void AddFactory(string name, List<ResourceAmount> inputs, List<ResourceAmount> outputs)
    {
        if (Factories.All(f => f.Name != name))
        {
            Factories.Add(new Factory { Name = name, Inputs = inputs, Outputs = outputs });
        }
    }

    public void RemoveFactory(string name)
    {
        Factories.RemoveAll(f => f.Name == name);
    }
}