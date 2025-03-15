public class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public double PricePerUnit { get; }
    public int Quantity { get; }

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}