using System.Diagnostics;

namespace C968_Ogden
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            errorProvider.BlinkRate = 0;
        }

        private ErrorProvider errorProvider = new();
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
            try
            {
                var selectedRow = AllCandidatePartTable.SelectedRows[0];
                Part tempPart = (Part)selectedRow.DataBoundItem;

                if (!AssociatedPartsBindingList.Contains(tempPart))
                {
                    AssociatedPartsBindingList.Add(tempPart);
                    AssociatedPartsTable.ClearSelection();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine($"An item must be selected.\n{ex.Message}");
            }
            catch (Exception ex)
            { Debug.WriteLine(ex.Message); }
        }

        private void RemoveAsscPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = AssociatedPartsTable.SelectedRows[0];
                Part tempPart = (Part)selectedRow.DataBoundItem;

                AssociatedPartsBindingList.Remove(tempPart);

                AssociatedPartsTable.ClearSelection();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine($"An item must be selected.\n{ex.Message}");
            }
            catch (Exception ex)
            { Debug.WriteLine(ex.Message); }
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
