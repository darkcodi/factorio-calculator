using FactorioCalculator.Models;

namespace FactorioCalculator.Services;

public class Catalog
{
    public List<Resource> Resources { get; set; } = new();
    public List<Factory> Factories { get; set; } = new();
    
    public void AddResource(string name)
    {
        if (Resources.All(r => r.Name != name))
        {
            Resources.Add(new Resource { Name = name });
        }
    }

    public void RemoveResource(string name)
    {
        Resources.RemoveAll(r => r.Name == name);
    }
}