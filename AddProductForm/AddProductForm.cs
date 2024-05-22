using System.Diagnostics;
using System.ComponentModel;

namespace C968_Ogden
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductCancel_Click(object sender, EventArgs e)
        {
            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();

            Close();
        }

        private void AddProductSave_Click(object sender, EventArgs e)
        {
            string prodName = AddProductNameInput.Text;
            int inventory = Convert.ToInt32(AddProductInventoryInput.Text);
            decimal price = Convert.ToDecimal(AddProductPriceInput.Text);
            int min = Convert.ToInt32(AddProductMinInput.Text);
            int max = Convert.ToInt32(AddProductMaxInput.Text);
            Product newProd = new(prodName, price, inventory, min, max);



            // foreach row in AssociatedPartsTable
            // newProd.AssociatedParts.Add(part from table)

            for (var i = 0; i < AssociatedPartsTable.Rows.Count; i++) { 
                var partRow = AssociatedPartsTable.Rows[i];
                Part part = (Part)partRow.DataBoundItem;
                newProd.AddAssociatedPart(part);
                Debug.WriteLine($"added {part.Name} to {newProd.Name}'s associated parts list.");
            }

            Inventory.Products.Add(newProd);
            Debug.WriteLine($"New Product: {newProd.Name}");
            Debug.WriteLine("\tAssociated Parts:");

            foreach (var part in newProd.AssociatedParts) {
                Debug.WriteLine($"\t{part.Name}");
            }

            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();

            Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            AllCandidatePartTable.ClearSelection();
            AssociatedPartsTable.ClearSelection();
            AddProductIdInput.Text = Product.IdPreview().ToString();
            AssociatedPartsTable.DataSource = AssociatedPartsBindingList;
        }

        private void AddAssociatePartButton_Click(object sender, EventArgs e)
        {
            var selectedRow = AllCandidatePartTable.SelectedRows[0];
            Part tempPart = (Part)selectedRow.DataBoundItem;

            AssociatedPartsBindingList.Add(tempPart);
            AssociatedPartsTable.ClearSelection();
        }
    }
}
