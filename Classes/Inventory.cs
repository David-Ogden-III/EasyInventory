using System.ComponentModel;

public static class Inventory
{

    //Required Properties
    public static BindingList<Product> Products { get; set; } = [];
    public static BindingList<Part> AllParts { get; set; } = [];



    //Required Methods

    // Product Methods
    public static void AddProduct(Product productToAdd)
    {
        Products.Add(productToAdd);
    }

    public static bool RemoveProduct(int indexToRemove)
    {
        Product prodToRemove = Products[indexToRemove];
        return Products.Remove(prodToRemove);
    }

    public static Product? LookupProduct(int prodId)
    {
        foreach (Product product in Products)
        {
            if (product.ProductId == prodId)
            {
                return product;
            }
        }

        return null;
    }
    public static Product? LookupProduct(string partName)
    {
        foreach (Product product in Products)
        {
            if (product.Name.ToLower() == partName)
            {
                return product;
            }
        }

        return null;
    }

    public static void UpdateProduct(int placeholder, Product placeholder2)
    {
        //Todo: update parameter and function body
    }

    // Part Methods
    public static void AddPart(Part partToAdd)
    {
        AllParts.Add(partToAdd);
    }

    public static bool DeletePart(Part partToDelete)
    {
        return AllParts.Remove(partToDelete);
    }

    public static Part? LookupPart(int partID)
    {
        foreach (Part part in AllParts)
        {
            if (part.PartId == partID) { return part; }
        }
        return null;
    }
    public static Part? LookupPart(string partName)
    {
        foreach (Part part in AllParts)
        {
            if (part.Name.ToLower() == partName) { return part; }
        }
        return null;
    }

    public static void UpdatePart(int rowIndex, Part updatedPart)
    {
        AllParts.Insert(rowIndex, updatedPart);
    }
}