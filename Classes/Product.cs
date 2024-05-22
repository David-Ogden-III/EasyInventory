using System.ComponentModel;
public class Product(string name, decimal price, int inStock, int min, int max, int? id = null)
{

    //Required Properties
    [DisplayName("Product ID")]
    public int ProductId
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
    public BindingList<Part> AssociatedParts { get; set; } = [];


    // Helper Fields
    private static int idCounter = 0;
    private readonly int id = (id != null ? (int)id : IdIncrement());



    //Required Methods
    public void AddAssociatedPart(Part partToAdd)
    {
        AssociatedParts.Add(partToAdd);
    }

    //TODO: change parameter to int
    public bool RemoveAssociatedPart(Part partToRemove)
    {
        bool success = AssociatedParts.Remove(partToRemove);
        return success;
    }

    //TODO: change parameter to int
    public Part LookupAssociatedPart(Part partToFind)
    {
        int partIndex = AssociatedParts.IndexOf(partToFind);
        return AssociatedParts[partIndex];
    }



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