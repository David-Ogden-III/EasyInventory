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

    public static void UpdateProduct(int placeholder, Product placeholder2)
    {
        //Todo: update parameter and function body
    }

    // Part Methods
    public static void AddPart(Part partToAdd)
    {
        AllParts.Add(partToAdd);
    }

    public static bool DeletePart(Part placeholder)
    {
        //Todo: update parameter and function body
        return true;
    }

    public static void LookupPart(int placeholder)
    {
        //Todo: update parameter, function body, return type, and return statement
    }

    public static void UpdatePart(int placeholder, Part placeholder2)
    {
        //Todo: update parameter and function body
    }
}