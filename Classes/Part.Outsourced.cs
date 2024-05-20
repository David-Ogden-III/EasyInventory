public class Outsourced : Part
{
    public string CompanyName { get; set; }

    public Outsourced(string name, decimal price, int inStock, int min, int max, string companyName) : base(name, price, inStock, min, max)
    {
        Name = name;
        Price = price;
        InStock = inStock;
        Min = min;
        Max = max;
        CompanyName = companyName;
    }
}