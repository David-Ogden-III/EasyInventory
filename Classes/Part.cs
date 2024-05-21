using System.ComponentModel;

public abstract class Part(string name, decimal price, int inStock, int min, int max, int? id = null)
{

    //Required Properties
    [DisplayName("Part ID")]
    public int PartId
    {
        get
        {
            return id;
        }
    }
    public string Name { get; set; } = name;
    [DisplayName("Inventory")]
    public int InStock { get; set; } = inStock;
    public decimal Price { get; set; } = price;
    public int Min { get; set; } = min;
    public int Max { get; set; } = max;




    // Helper Fields
    private static int idCounter = 0;
    private readonly int id = (id != null ? (int)id : IdIncrement());



    //Helper Methods
    private static int IdIncrement()
    {
        idCounter += 1;
        return idCounter;
    }

    public static int IdPreview()
    {
        int tempId = idCounter + 1;
        return tempId;
    }
}