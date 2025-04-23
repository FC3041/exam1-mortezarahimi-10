using System.Reflection.PortableExecutable;

public interface DiscountStrategy
{
    public double CalculatePrice(double price);
}

public class PricingEngine
{
    public DiscountStrategy d_strategy { get; private set; }

    public PricingEngine(DiscountStrategy ds)
    {
        this.d_strategy = ds;
    }

    public double CalculatePrice(double price)
    {
        return d_strategy.CalculatePrice(price);
    }

    public void SetStrategy(DiscountStrategy ds)
    {
        this.d_strategy = ds;
    }
}

public class NoDiscountStrategy : DiscountStrategy
{
    public double CalculatePrice(double price)
    { return price; }
}

public class PercentageDiscountStrategy : DiscountStrategy
{
    public double discount_precentage { get; set; }
    public PercentageDiscountStrategy(double dp)
    {
        this.discount_precentage = dp;
    }

    public double CalculatePrice(double price)
    {
        return price - (price * this.discount_precentage);     
    }
}