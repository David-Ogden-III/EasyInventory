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
            errorProvider.BlinkRate = 0;
        }

        private ErrorProvider errorProvider = new();
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
            bool hasExceptions = ValidateInput();
            if (hasExceptions) return;

            // Create new Product from input fields
            int id = Convert.ToInt32(AddProductIdInput.Text);
            string partName = AddProductNameInput.Text;
            int inventory = Convert.ToInt32(AddProductInventoryInput.Text);
            decimal price = Convert.ToDecimal(AddProductPriceInput.Text);
            int min = Convert.ToInt32(AddProductMinInput.Text);
            int max = Convert.ToInt32(AddProductMaxInput.Text);
            Product newProduct = new(partName, price, inventory, min, max, id);


            // Create new array with parts from ProductToModify.AssociatedParts
            Part[] array = new Part[ProductToModify.AssociatedParts.Count];
            for (var i = 0; i < ProductToModify.AssociatedParts.Count; i++)
            {
                array[i] = ProductToModify.AssociatedParts[i];
            }


            // Remove Part from ProductToModify.AssociatedParts if they were not in the associated parts table
            foreach (var part in array)
            {
                if (!AssociatedPartsBindingList.Contains(part))
                {
                    int i = ProductToModify.AssociatedParts.IndexOf(part);
                    ProductToModify.RemoveAssociatedPart(i);
                }
            }

            newProduct.AssociatedParts = ProductToModify.AssociatedParts;

            // Add Part to newProduct.AssociatedParts if it is not already present
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


            // Overwrites product with new product
            Inventory.UpdateProduct(SelectedRowIndex, newProduct);

            //Closes Form
            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();
            Close();
        }

        private void RemoveAsscPartButton_Click(object sender, EventArgs e)
        {
            var selectedRow = AssociatedPartsTable.SelectedRows[0];
            Part tempPart = (Part)selectedRow.DataBoundItem;

            DeleteDialog dialog = new(tempPart, AssociatedPartsBindingList);
            dialog.ShowDialog();

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




        // Helper Methods - Form Validation
        private bool ValidateInput()
        {
            HideInputErrors();

            bool hasExceptions = false;


            bool inventorySuccess = int.TryParse(AddProductInventoryInput.Text, out int inventory);
            if (AddProductInventoryInput.Text.Length <= 0)
            {
                InputLengthError(AddProductInventoryInput);
                hasExceptions = true;
            }
            else if (!inventorySuccess)
            {
                IntParseError(AddProductInventoryInput);
                hasExceptions = true;
            }

            bool priceSuccess = decimal.TryParse(AddProductPriceInput.Text, out decimal price);
            if (AddProductPriceInput.Text.Length <= 0)
            {
                InputLengthError(AddProductPriceInput);
                hasExceptions = true;
            }
            else if (!priceSuccess)
            {
                DecimalParseError(AddProductPriceInput);
                hasExceptions = true;
            }

            bool minSuccess = int.TryParse(AddProductMinInput.Text, out int min);
            if (AddProductMinInput.Text.Length <= 0)
            {
                InputLengthError(AddProductMinInput);
                hasExceptions = true;
            }
            else if (!minSuccess)
            {
                IntParseError(AddProductMinInput);
                hasExceptions = true;
            }

            bool maxSuccess = int.TryParse(AddProductMaxInput.Text, out int max);
            if (AddProductMaxInput.Text.Length <= 0)
            {
                InputLengthError(AddProductMaxInput);
                hasExceptions = true;
            }
            else if (!maxSuccess)
            {
                IntParseError(AddProductMaxInput);
                hasExceptions = true;
            }

            if (AddProductNameInput.Text.Length <= 0)
            {
                InputLengthError(AddProductNameInput);
                hasExceptions = true;
            }


            if (minSuccess && maxSuccess)
            {
                if (min > max)
                {
                    MinMaxBoundsError(AddProductMinInput, AddProductMaxInput);
                    hasExceptions = true;
                }
                else if (inventorySuccess && (min > inventory || inventory > max))
                {
                    AddProductInventoryInput.BackColor = Color.LightCoral;
                    errorProvider.SetError(AddProductInventoryInput, "Inventory must be <= min and >= max");
                    hasExceptions = true;
                }
            }

            return hasExceptions;
        }

        private void HideInputErrors()
        {
            Color backColor = SystemColors.Window;

            AddProductInventoryInput.BackColor = backColor;
            AddProductPriceInput.BackColor = backColor;
            AddProductMinInput.BackColor = backColor;
            AddProductMaxInput.BackColor = backColor;
            AddProductNameInput.BackColor = backColor;

            errorProvider.SetError(AddProductMaxInput, "");
            errorProvider.SetError(AddProductMinInput, "");
            errorProvider.SetError(AddProductInventoryInput, "");
            errorProvider.SetError(AddProductPriceInput, "");
            errorProvider.SetError(AddProductNameInput, "");
        }
        private void IntParseError(TextBox textBoxName)
        {
            Color errorBackColor = Color.LightCoral;

            textBoxName.BackColor = errorBackColor;
            errorProvider.SetError(textBoxName, "Must be an integer");
        }

        private void DecimalParseError(TextBox textBoxName)
        {
            Color errorBackColor = Color.LightCoral;

            textBoxName.BackColor = errorBackColor;
            errorProvider.SetError(textBoxName, "Must be a number");

        }

        private void InputLengthError(TextBox textBoxName)
        {
            Color errorBackColor = Color.LightCoral;

            textBoxName.BackColor = errorBackColor;
            errorProvider.SetError(textBoxName, "Required");

        }

        private void MinMaxBoundsError(TextBox min, TextBox max)
        {
            Color errorBackColor = Color.LightCoral;
            string errMessge = "Min must be less than or equal to Max";

            min.BackColor = errorBackColor;
            errorProvider.SetError(min, errMessge);

            max.BackColor = errorBackColor;
            errorProvider.SetError(max, errMessge);
        }
    }
}
