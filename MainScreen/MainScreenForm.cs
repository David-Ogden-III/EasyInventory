using System.Diagnostics;

namespace C968_Ogden;

public partial class MainScreen : Form
{
    public MainScreen()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ClearSelection();
    }

    private void MainExitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // Part Controls
    private void PartDeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedRow = PartTable.SelectedRows[0];
            Part partToDelete = (Part)selectedRow.DataBoundItem;

            DeleteDialog dialog = new(partToDelete);
            dialog.ShowDialog();

            PartTable.ClearSelection();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Debug.WriteLine($"An item must be selected.\n{ex.Message}");
        }
        catch (Exception ex)
        { Debug.WriteLine(ex.Message); }
    }

    private void PartModifyButton_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedRow = PartTable.SelectedRows[0];
            int selectedRowIndex = selectedRow.Index;
            Part partToModify = (Part)selectedRow.DataBoundItem;
            string? partType = PartTable.CurrentRow.DataBoundItem.ToString();


            if (partType == "Outsourced")
            {
                partToModify = (Outsourced)partToModify;
            }
            else
            {
                partToModify = (InHouse)partToModify;
            }

            if (partToModify != null && partType != null)
            {
                ModifyPartForm modifyPartForm = new(partToModify, partType, selectedRowIndex)
                { Tag = this };
                modifyPartForm.Show(this);
                Hide();
            }
            ClearSelection();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Debug.WriteLine($"An item must be selected.\n{ex.Message}");
        }
        catch (Exception ex)
        { Debug.WriteLine(ex.Message); }
    }

    private void PartAddButton_Click(object sender, EventArgs e)
    {
        AddPartForm addPartForm = new()
        {
            Tag = this
        };
        addPartForm.Show(this);
        Hide();
        ClearSelection();
    }
    private void PartSearchButton_Click(object sender, EventArgs e)
    {
        ClearSelection();
        string rawSearchParams = PartSearch.Text;
        string searchParams = rawSearchParams.ToLower().Trim();


        for (int i = 0; i < PartTable.Rows.Count; i++)
        {
            PartTable.Rows[i].Visible = true;
        }

        if (searchParams == "")
        {
            return;
        }

        Part? foundPart = null;
        if (int.TryParse(searchParams, out int id))
        {
            foundPart = Inventory.LookupPart(id);
        }
        else
        {
            foundPart = Inventory.LookupPart(searchParams);
        }

        if (foundPart != null)
        {
            for (var i = 0; i < PartTable.Rows.Count; i++)
            {
                var currentRow = PartTable.Rows[i];
                Part currentPart = (Part)currentRow.DataBoundItem;
                if (currentPart != foundPart)
                {
                    CurrencyManager? currencyManager = (CurrencyManager)BindingContext[PartTable.DataSource];
                    currencyManager.SuspendBinding();
                    PartTable.Rows[i].Visible = false;
                    currencyManager.ResumeBinding();
                }
            }

        }
        else
        {
            NotifyDialog dialog = new();
            dialog.ShowDialog();
        }
        PartSearch.Text = "";
    }

    private void PartSearchEnter(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            PartSearchButton_Click(sender, new EventArgs());
            e.SuppressKeyPress = true;
        }
    }

    // Product Controls
    private void ProductAddButton_Click(object sender, EventArgs e)
    {
        AddProductForm addProductForm = new()
        {
            Tag = this
        };
        addProductForm.Show(this);
        Hide();
        ClearSelection();
    }

    private void ProductModifyButton_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedRow = ProductTable.SelectedRows[0];
            int selectedRowIndex = selectedRow.Index;
            Product productToModify = (Product)selectedRow.DataBoundItem;


            ModifyProductForm modifyProductForm = new(productToModify, selectedRowIndex)
            { Tag = this };
            modifyProductForm.Show(this);
            Hide();
            ClearSelection();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Debug.WriteLine($"An item must be selected.\n{ex.Message}");
        }
        catch (Exception ex)
        { Debug.WriteLine(ex.Message); }
    }

    private void ProductDeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            int selectedProdIndex = ProductTable.SelectedRows[0].Index;
            int asscPartsLength = Inventory.Products[selectedProdIndex].AssociatedParts.Count;

            if (asscPartsLength > 0)
            {
                NotifyDialog dialog = new("Prod Has Parts");
                dialog.ShowDialog();
            }
            else
            {
                DeleteDialog dialog = new(selectedProdIndex);
                dialog.ShowDialog();
            }

            ClearSelection();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Debug.WriteLine($"An item must be selected.\n{ex.Message}");
        }
        catch (Exception ex)
        { Debug.WriteLine(ex.Message); }
    }

    private void ProductSearchButton_Click(object sender, EventArgs e)
    {
        ClearSelection();
        string rawSearchParams = ProductSearch.Text;
        string searchParams = rawSearchParams.ToLower().Trim();


        for (int i = 0; i < ProductTable.Rows.Count; i++)
        {
            ProductTable.Rows[i].Visible = true;
        }

        if (searchParams == "")
        {
            return;
        }

        Product? foundProduct = null;
        if (int.TryParse(searchParams, out int id))
        {
            foundProduct = Inventory.LookupProduct(id);
        }
        else
        {
            foundProduct = Inventory.LookupProduct(searchParams);
        }

        if (foundProduct != null)
        {
            for (var i = 0; i < ProductTable.Rows.Count; i++)
            {
                var currentRow = ProductTable.Rows[i];
                Product currentProdcut = (Product)currentRow.DataBoundItem;
                if (currentProdcut != foundProduct)
                {
                    CurrencyManager? currencyManager = (CurrencyManager)BindingContext[ProductTable.DataSource];
                    currencyManager.SuspendBinding();
                    ProductTable.Rows[i].Visible = false;
                    currencyManager.ResumeBinding();
                }
            }

        }
        else
        {
            NotifyDialog dialog = new();
            dialog.ShowDialog();
        }
        ProductSearch.Text = "";
    }
    private void ProductSearchEnter(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            ProductSearchButton_Click(sender, new EventArgs());
            e.SuppressKeyPress = true;
        }
    }

    // Helper Methods
    private void ClearSelection()
    {
        PartTable.ClearSelection();
        ProductTable.ClearSelection();
    }
    public void ClearTableSelections()
    {
        ClearSelection();
    }
}
