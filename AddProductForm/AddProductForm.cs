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
            //Create new Product from inputs
            string prodName = AddProductNameInput.Text;
            int inventory = Convert.ToInt32(AddProductInventoryInput.Text);
            decimal price = Convert.ToDecimal(AddProductPriceInput.Text);
            int min = Convert.ToInt32(AddProductMinInput.Text);
            int max = Convert.ToInt32(AddProductMaxInput.Text);
            Product newProd = new(prodName, price, inventory, min, max);


            // Add Parts from Associated Parts table to Product, only if they're not associated already
            for (var i = 0; i < AssociatedPartsTable.Rows.Count; i++)
            {
                var partRow = AssociatedPartsTable.Rows[i];
                Part part = (Part)partRow.DataBoundItem;

                if (!newProd.AssociatedParts.Contains(part))
                {
                    newProd.AddAssociatedPart(part); //Required function for Product Class
                    Debug.WriteLine($"added {part.Name} to {newProd.Name}'s associated parts list.");
                }
                else
                {
                    Debug.WriteLine($"{part.Name} is already associated with this product");
                }
            }

            // Add Product to Inventory
            Inventory.Products.Add(newProd);
            
            // Close  form, show MainScreen
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

            if (!AssociatedPartsBindingList.Contains(tempPart))
            {
                AssociatedPartsBindingList.Add(tempPart);
                AssociatedPartsTable.ClearSelection();
            }
        }

        private void RemoveAsscPartButton_Click(object sender, EventArgs e)
        {
            var selectedRow = AssociatedPartsTable.SelectedRows[0];
            Part tempPart = (Part)selectedRow.DataBoundItem;

            AssociatedPartsBindingList.Remove(tempPart);

            AssociatedPartsTable.ClearSelection();
        }

        private void SearchCandidatePartButton_Click(object sender, EventArgs e)
        {
            AllCandidatePartTable.ClearSelection();
            string rawSearchParams = SearchCandidatePartsInput.Text;
            string searchParams = rawSearchParams.ToLower().Trim();


            for (int i = 0; i < AllCandidatePartTable.Rows.Count; i++)
            {
                AllCandidatePartTable.Rows[i].Visible = true;
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
                for (var i = 0; i < AllCandidatePartTable.Rows.Count; i++)
                {
                    var currentRow = AllCandidatePartTable.Rows[i];
                    Part currentPart = (Part)currentRow.DataBoundItem;
                    if (currentPart != foundPart)
                    {
                        CurrencyManager? currencyManager = (CurrencyManager)BindingContext[AllCandidatePartTable.DataSource];
                        currencyManager.SuspendBinding();
                        AllCandidatePartTable.Rows[i].Visible = false;
                        currencyManager.ResumeBinding();
                    }
                }

            }
            else
            {
                NotifyDialog dialog = new();
                dialog.ShowDialog();
            }
            SearchCandidatePartsInput.Text = "";
        }

        private void PartSearchEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCandidatePartButton_Click(sender, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
    }
}
