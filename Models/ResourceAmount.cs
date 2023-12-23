namespace FactorioCalculator.Models;

public class ResourceAmount
{
    public string Resource { get; set; }
    public double Amount { get; set; }

    public ResourceAmount()
    {
    }

    public ResourceAmount(string resource, double amount)
    {
        Resource = resource;
        Amount = amount;
    }
}