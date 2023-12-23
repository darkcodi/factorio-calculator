namespace FactorioCalculator.Models;

public class Factory
{
    public string Name { get; set; }
    public List<ResourceAmount> Inputs { get; set; }
    public List<ResourceAmount> Outputs { get; set; }
}