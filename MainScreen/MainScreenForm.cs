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
        PartTable.ClearSelection();
        ProductTable.ClearSelection();
    }

    private void MainExitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // Part Controls
    private void PartDeleteButton_Click(object sender, EventArgs e)
    {
        int selectedRowIndex = PartTable.CurrentRow.Index;
        int partId = Convert.ToInt32(PartTable[0, selectedRowIndex].Value);
        string? partType = PartTable.CurrentRow.DataBoundItem.ToString();
        dynamic? partToDelete = null;

        foreach (Part part in Inventory.AllParts)
        {
            if (part.PartId == partId)
            {
                if (partType == "Outsourced")
                {
                    partToDelete = (Outsourced)part;
                    break;
                }
                else
                {
                    partToDelete = (InHouse)part;
                    break;
                }
            }
        }

        if (partToDelete != null)
        {
            DeleteDialog dialog = new(partToDelete: partToDelete);
            dialog.ShowDialog();
        }
    }

    private void PartModifyButton_Click(object sender, EventArgs e)
    {
        int selectedRowIndex = PartTable.CurrentRow.Index;
        int partId = Convert.ToInt32(PartTable[0, selectedRowIndex].Value);
        string? partType = PartTable.CurrentRow.DataBoundItem.ToString();
        Part? partToModify = null;

        foreach (Part part in Inventory.AllParts)
        {
            if (part.PartId == partId)
            {
                if (partType == "Outsourced")
                {
                    partToModify = (Outsourced)part;
                    break;
                }
                else
                {
                    partToModify = (InHouse)part;
                    break;
                }
            }
        }

        if (partToModify != null && partType != null) {
            ModifyPartForm modifyPartForm = new(partToModify, partType, selectedRowIndex)
            { Tag = this };
            modifyPartForm.Show(this);
            Hide();
        }
        
    }

    private void PartAddButton_Click(object sender, EventArgs e)
    {
        AddPartForm addPartForm = new()
        {
            Tag = this
        };
        addPartForm.Show(this);
        Hide();
    }

    private void PartSearch_TextChanged(object sender, EventArgs e)
    {

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
    }

    private void ProductModifyButton_Click(object sender, EventArgs e)
    {
        ModifyProductForm modifyProductForm = new()
        {
            Tag = this
        };
        modifyProductForm.Show(this);
        Hide();
    }

    private void ProductDeleteButton_Click(object sender, EventArgs e)
    {
        //DeleteDialog dialog = new();
        //dialog.ShowDialog();
    }
}
