using System.ComponentModel;
using System.Diagnostics;
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

    public bool RemoveAssociatedPart(int partIndex)
    {
        Part partToRemove = AssociatedParts[partIndex];
        string partName = partToRemove.Name;

        bool success = AssociatedParts.Remove(partToRemove);
        Debug.WriteLineIf(success, $"{partName} removed from {Name}'s associated parts list");
        return success;
    }

    public Part LookupAssociatedPart(int partIndex)
    {
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