namespace FactorioCalculator.Models;

public class Factory
{
    public Factory(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public string Name { get; }
    public IReadOnlyCollection<ResourceAmount> Inputs { get; init; } = new List<ResourceAmount>();
    public IReadOnlyCollection<ResourceAmount> Outputs { get; init; } = new List<ResourceAmount>();
}