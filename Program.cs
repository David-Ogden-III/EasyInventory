using System.Diagnostics;

namespace C968_Ogden;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        // Dummy Data
        // Initialize Objects
        Product dirtBike = new("Dirt Bike", 3999.99M, 10, 3, 20);
        Product atv = new("ATV", 4999.99M, 8, 3, 20);
        Product utv = new("UTV", 12999.99M, 2, 0, 5);
        Outsourced wheel = new("Wheel", 499.99M, 3, 0, 5, "Dunlop");
        Outsourced brakes = new("Brakes", 129.99M, 1, 0, 10, "Shimona");
        Outsourced chain = new("Chain", 89.99M, 7, 5, 15, "EK");
        InHouse fender = new("Fender", 369.99M, 8, 12, 20, 37634);
        InHouse handlebars = new("Handlebars", 239.99M, 6, 5, 12, 15479);
        InHouse suspension = new("Suspension", 799.99M, 6, 7, 8, 35964);

        // Add Parts to Associated Parts lists
        dirtBike.AddAssociatedPart(fender);
        dirtBike.AddAssociatedPart(wheel);
        dirtBike.AddAssociatedPart(handlebars);
        dirtBike.AddAssociatedPart(suspension);
        dirtBike.AddAssociatedPart(brakes);
        dirtBike.AddAssociatedPart(chain);
        atv.AddAssociatedPart(fender);
        atv.AddAssociatedPart(wheel);
        atv.AddAssociatedPart(handlebars);

        // Add Parts and Products to Inventory Lists
        Inventory.AddProduct(dirtBike);
        Inventory.AddProduct(atv);
        Inventory.AddProduct(utv);
        Inventory.AddPart(fender);
        Inventory.AddPart(wheel);
        Inventory.AddPart(brakes);
        Inventory.AddPart(handlebars);
        Inventory.AddPart(suspension);
        Inventory.AddPart(chain);
        Debug.WriteLine(wheel.Name);
        Debug.WriteLine(Inventory.Products[0].Name);

        ApplicationConfiguration.Initialize();
        Application.Run(new MainScreen());
    }    
}