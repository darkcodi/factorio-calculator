using FactorioCalculator.Models;

namespace FactorioCalculator.Services;

public class BasePlan
{
    private readonly List<Factory> _factories = new();
    private readonly List<int> _factoryCounts = new();
    private readonly List<string> _resources = new();
    private readonly List<double> _resourceAmounts = new();

    public IReadOnlyCollection<(Factory Factory, int Count)> Factories => _factories.Select((f, i) => (f, _factoryCounts[i])).ToList();
    public IReadOnlyCollection<(string Resource, double Amount)> Resources => _resources.Select((r, i) => (r, _resourceAmounts[i])).OrderBy(x => x.r).ToList();

    public void AddFactory(Factory factory, ushort count = 0)
    {
        if (_factories.All(f => f.Name != factory.Name))
        {
            _factories.Add(factory);
            _factoryCounts.Add(0);
            AddFactories(factory.Name, count);
        }
    }

    public void RemoveFactory(string factoryName)
    {
        var index = _factories.FindIndex(f => f.Name == factoryName);
        if (index == -1) return;
        AddFactories(_factories[index].Name, -_factoryCounts[index]);
        _factories.RemoveAt(index);
        _factoryCounts.RemoveAt(index);
    }

    public void IncreaseFactoryCount(string factoryName) => AddFactories(factoryName, 1);
    public void DecreaseFactoryCount(string factoryName) => AddFactories(factoryName, -1);

    private void AddFactories(string factoryName, int count)
    {
        var factoryIndex = _factories.FindIndex(f => f.Name == factoryName);
        if (factoryIndex == -1) return;
        if (_factoryCounts[factoryIndex] + count < 0) return;
        _factoryCounts[factoryIndex] += count;
        var factory = _factories[factoryIndex];
        foreach (var input in factory.Inputs)
        {
            AddResource(input.Resource, -input.Amount * count);
        }
        foreach (var output in factory.Outputs)
        {
            AddResource(output.Resource, output.Amount * count);
        }

        // Remove all resources that are not used by any factory
        for (var i = _resources.Count - 1; i >= 0; i--)
        {
            if (_resourceAmounts[i] == 0)
            {
                _resources.RemoveAt(i);
                _resourceAmounts.RemoveAt(i);
            }
        }
    }

    private void AddResource(string resource, double amount)
    {
        var resourceIndex = _resources.FindIndex(x => x == resource);
        if (resourceIndex == -1)
        {
            _resources.Add(resource);
            _resourceAmounts.Add(amount);
        }
        else
        {
            _resourceAmounts[resourceIndex] += amount;
        }
    }
}