public class InHouse : Part
{
    public int MachineId { get; set; }

    public InHouse(string name, decimal price, int inStock, int min, int max, int machineId, int? id = null) : base(name, price, inStock, min, max, id)
    {
        Name = name;
        Price = price;
        InStock = inStock;
        Min = min;
        Max = max;
        MachineId = machineId;
    }
}