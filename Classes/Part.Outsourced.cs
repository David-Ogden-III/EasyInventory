public class Outsourced : Part
{
    public string CompanyName { get; set; }

    public Outsourced(string name, decimal price, int inStock, int min, int max, string companyName, int? id = null) : base(name, price, inStock, min, max, id)
    {
        Name = name;
        Price = price;
        InStock = inStock;
        Min = min;
        Max = max;
        CompanyName = companyName;
    }
}