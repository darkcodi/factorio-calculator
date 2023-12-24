using FactorioCalculator.Models;

namespace FactorioCalculator.Services;

public class BasePlan
{
    // singleton
    private static BasePlan _instance;
    public static BasePlan Instance => _instance ??= new BasePlan();
    private BasePlan() { }

    private readonly List<Factory> _factories = new();
    private readonly List<int> _factoryCounts = new();
    private readonly List<string> _resources = new();
    private readonly List<double> _resourceAmounts = new();

    public IReadOnlyCollection<(Factory Factory, int Count)> Factories => _factories.Select((f, i) => (f, _factoryCounts[i])).ToList();
    public IReadOnlyCollection<(string Resource, double Amount, double AllAmount)> Resources => GetAllResources();
    public bool HasAnyNegativeResource => _resourceAmounts.Any(x => x < 0);
    public bool HasAnyZeroResource => _resourceAmounts.Any(x => x == 0);

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

    public void EnsurePositiveResource(string resource)
    {
        var resourceIndex = _resources.FindIndex(x => x == resource);
        if (resourceIndex == -1) return;
        if (_resourceAmounts[resourceIndex] < 0)
        {
            var factoryIndex = _factories.FindIndex(f => f.Outputs.Any(o => o.Resource == resource));
            if (factoryIndex == -1) return;
            var factory = _factories[factoryIndex];
            var neededFactoryCount = (int)Math.Ceiling(Math.Abs(_resourceAmounts[resourceIndex]) / factory.Outputs.First(o => o.Resource == resource).Amount);
            AddFactories(factory.Name, neededFactoryCount);
        }
    }

    public void EnsureAllResourceNonNegative()
    {
        while (true)
        {
            var negativeResourceIndex = _resourceAmounts.FindIndex(x => x < 0);
            if (negativeResourceIndex == -1) break;
            var resource = _resources[negativeResourceIndex];
            EnsurePositiveResource(resource);
        }
    }

    public void IncreaseResource(string resource)
    {
        var resourceIndex = _resources.FindIndex(x => x == resource);
        if (resourceIndex == -1) return;
        var factoryIndex = _factories.FindIndex(f => f.Outputs.Any(o => o.Resource == resource));
        if (factoryIndex == -1) return;
        var factory = _factories[factoryIndex];
        AddFactories(factory.Name, 1);
    }

    public void IncreaseAllZeroResources()
    {
        while (true)
        {
            var zeroResourceIndex = _resourceAmounts.FindIndex(x => x == 0);
            if (zeroResourceIndex == -1) break;
            var resource = _resources[zeroResourceIndex];
            IncreaseResource(resource);
        }
    }

    public void IncreaseFactoryCount(string factoryName) => AddFactories(factoryName, 1);
    public void DecreaseFactoryCount(string factoryName) => AddFactories(factoryName, -1);

    public void Reset()
    {
        _factories.Clear();
        _factoryCounts.Clear();
        _resources.Clear();
        _resourceAmounts.Clear();
    }

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

        // // Remove all resources that are not used by any factory
        // for (var i = _resources.Count - 1; i >= 0; i--)
        // {
        //     if (_resourceAmounts[i] == 0)
        //     {
        //         _resources.RemoveAt(i);
        //         _resourceAmounts.RemoveAt(i);
        //     }
        // }
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

    private IReadOnlyCollection<(string Resource, double Amount, double AllAmount)> GetAllResources()
    {
        var resources = _resources
            .Select((r, i) => (Resource: r, Amount: _resourceAmounts[i], TotalAmount: _resourceAmounts[i]))
            .OrderBy(x => x.Resource)
            .ToList();
        for (var factoryIndex = 0; factoryIndex < _factories.Count; factoryIndex++)
        {
            var factory = _factories[factoryIndex];
            foreach (var input in factory.Inputs)
            {
                var resourceIndex = resources.FindIndex(x => x.Resource == input.Resource);
                if (resourceIndex == -1)
                {
                    resources.Add((input.Resource, input.Amount * _factoryCounts[factoryIndex], input.Amount * _factoryCounts[factoryIndex]));
                }
                else
                {
                    var resource = resources[resourceIndex];
                    resources[resourceIndex] = (resource.Resource, resource.Amount, resource.TotalAmount + input.Amount * _factoryCounts[factoryIndex]);
                }
            }
        }
        return resources;
    }
}