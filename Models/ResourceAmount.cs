namespace FactorioCalculator.Models;

public record ResourceAmount
{
    public string Resource { get; set; }
    public double Amount { get; set; }

    public ResourceAmount(string resource, double amount)
    {
        Resource = resource;
        Amount = amount;
    }
}