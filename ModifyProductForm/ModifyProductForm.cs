using System.ComponentModel;
using System.Diagnostics;

namespace C968_Ogden
{
    public partial class ModifyProductForm : Form
    {
        public ModifyProductForm(Product productToModify, int selectedRowIndex)
        {
            InitializeComponent();
            ProductToModify = productToModify;
            SelectedRowIndex = selectedRowIndex;
        }

        private Product ProductToModify { get; set; }
        private int SelectedRowIndex { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddProductIdInput.Text = ProductToModify.ProductId.ToString();
            AddProductNameInput.Text = ProductToModify.Name.ToString();
            AddProductInventoryInput.Text = ProductToModify.InStock.ToString();
            AddProductPriceInput.Text = ProductToModify.Price.ToString();
            AddProductMinInput.Text = ProductToModify.Min.ToString();
            AddProductMaxInput.Text = ProductToModify.Max.ToString();
            AssociatedPartsTable.DataSource = AssociatedPartsBindingList;
            foreach (var part in ProductToModify.AssociatedParts)
            {
                AssociatedPartsBindingList.Add(part);
            }
            AllCandidatePartTable.ClearSelection();
            AssociatedPartsTable.ClearSelection();
        }

        private void AddProductCancel_Click(object sender, EventArgs e)
        {
            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();

            Close();
        }

        private void AddProductSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AddProductIdInput.Text);
            string partName = AddProductNameInput.Text;
            int inventory = Convert.ToInt32(AddProductInventoryInput.Text);
            decimal price = Convert.ToDecimal(AddProductPriceInput.Text);
            int min = Convert.ToInt32(AddProductMinInput.Text);
            int max = Convert.ToInt32(AddProductMaxInput.Text);
            Product newProduct = new(partName, price, inventory, min, max, id);

            //for (var i = 0; i < ProductToModify.AssociatedParts.Count; i++)
            //{
            //    if (!AssociatedPartsBindingList.Contains(ProductToModify.AssociatedParts[i]))
            //    {
            //        Debug.WriteLine("HElp");
            //        ProductToModify.RemoveAssociatedPart(i);
            //    }
            //}
            Part[] array = new Part[ProductToModify.AssociatedParts.Count];
            for (var i = 0; i < ProductToModify.AssociatedParts.Count; i++)
            {
                array[i] = ProductToModify.AssociatedParts[i];
            }

            foreach (var part in array)
            {
                if (!AssociatedPartsBindingList.Contains(part))
                {
                    int i = ProductToModify.AssociatedParts.IndexOf(part);
                    ProductToModify.RemoveAssociatedPart(i);
                }
            }

            newProduct.AssociatedParts = ProductToModify.AssociatedParts;

            for (var i = 0; i < AssociatedPartsTable.Rows.Count; i++)
            {
                var partRow = AssociatedPartsTable.Rows[i];
                Part part = (Part)partRow.DataBoundItem;

                if (!newProduct.AssociatedParts.Contains(part))
                {
                    newProduct.AddAssociatedPart(part); //Required function for Product Class
                    Debug.WriteLine($"added {part.Name} to {newProduct.Name}'s associated parts list.");
                }
                else
                {
                    Debug.WriteLine($"{part.Name} is already associated with this product");
                }
            }




            Inventory.UpdateProduct(SelectedRowIndex, newProduct);

            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();
            Close();
        }

        private void RemoveAsscPartButton_Click(object sender, EventArgs e)
        {
            var selectedRow = AssociatedPartsTable.SelectedRows[0];
            Part tempPart = (Part)selectedRow.DataBoundItem;

            AssociatedPartsBindingList.Remove(tempPart);
            AssociatedPartsTable.ClearSelection();
        }

        private void AddAssociatePartButton_Click(object sender, EventArgs e)
        {
            var selectedRow = AllCandidatePartTable.SelectedRows[0];
            Part tempPart = (Part)selectedRow.DataBoundItem;

            if (!AssociatedPartsBindingList.Contains(tempPart))
            {
                AssociatedPartsBindingList.Add(tempPart);
                AssociatedPartsTable.ClearSelection();
            }
        }

        private void SearchCandidatePartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
