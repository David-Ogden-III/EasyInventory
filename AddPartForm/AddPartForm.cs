namespace C968_Ogden
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            errorProvider.BlinkRate = 0;
        }

        private ErrorProvider errorProvider = new();

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            string idPreview = Part.IdPreview().ToString();
            AddPartIdInput.Text = idPreview;

        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            bool hasExceptions = ValidateInput();
            if (hasExceptions) return;

            string partName = AddPartNameInput.Text;
            int inventory = Convert.ToInt32(AddPartInventoryInput.Text);
            decimal price = Convert.ToDecimal(AddPartPriceInput.Text);
            int min = Convert.ToInt32(AddPartMinInput.Text);
            int max = Convert.ToInt32(AddPartMaxInput.Text);
            dynamic newPart;

            if (OutsourcedRadio.Checked)
            {
                string compName = AddPartManufactureInput.Text;
                newPart = new Outsourced(partName, price, inventory, min, max, compName);
            }
            else
            {
                int machineId = Convert.ToInt32(AddPartManufactureInput.Text);
                newPart = new InHouse(partName, price, inventory, min, max, machineId);
            }
            Inventory.AddPart(newPart);

            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();
            Close();
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();

            Close();
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMachineIdLabel.Hide();
            AddPartCompanyNameLabel.Show();
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartCompanyNameLabel.Hide();
            AddPartMachineIdLabel.Show();
        }





        // Helper Methods - Form Validation
        private bool ValidateInput()
        {
            HideInputErrors();

            bool hasExceptions = false;


            bool inventorySuccess = int.TryParse(AddPartInventoryInput.Text, out int inventory);
            if (AddPartInventoryInput.Text.Length <= 0)
            {
                InputLengthError(AddPartInventoryInput);
                hasExceptions = true;
            }
            else if (!inventorySuccess)
            {
                IntParseError(AddPartInventoryInput);
                hasExceptions = true;
            }

            bool priceSuccess = decimal.TryParse(AddPartPriceInput.Text, out decimal price);
            if (AddPartPriceInput.Text.Length <= 0)
            {
                InputLengthError(AddPartPriceInput);
                hasExceptions = true;
            }
            else if (!priceSuccess)
            {
                DecimalParseError(AddPartPriceInput);
                hasExceptions = true;
            }

            bool minSuccess = int.TryParse(AddPartMinInput.Text, out int min);
            if (AddPartMinInput.Text.Length <= 0)
            {
                InputLengthError(AddPartMinInput);
                hasExceptions = true;
            }
            else if (!minSuccess)
            {
                IntParseError(AddPartMinInput);
                hasExceptions = true;
            }

            bool maxSuccess = int.TryParse(AddPartMaxInput.Text, out int max);
            if (AddPartMaxInput.Text.Length <= 0)
            {
                InputLengthError(AddPartMaxInput);
                hasExceptions = true;
            }
            else if (!maxSuccess)
            {
                IntParseError(AddPartMaxInput);
                hasExceptions = true;
            }

            if (AddPartNameInput.Text.Length <= 0)
            {
                InputLengthError(AddPartNameInput);
                hasExceptions = true;
            }

            if (InHouseRadio.Checked)
            {
                bool machineSuccess = int.TryParse(AddPartManufactureInput.Text, out int machine);
                if (AddPartManufactureInput.Text.Length <= 0)
                {
                    InputLengthError(AddPartManufactureInput);
                    hasExceptions = true;
                }
                else if (!machineSuccess)
                {
                    IntParseError(AddPartManufactureInput);
                    hasExceptions = true;
                }
            }
            else if (OutsourcedRadio.Checked)
            {
                if (AddPartManufactureInput.Text.Length <= 0)
                {
                    InputLengthError(AddPartManufactureInput);
                    hasExceptions = true;
                }
            }


            if (minSuccess && maxSuccess)
            {
                if (min > max)
                {
                    MinMaxBoundsError(AddPartMinInput, AddPartMaxInput);
                    hasExceptions = true;
                }
                else if (inventorySuccess && (min > inventory || inventory > max))
                {
                    AddPartInventoryInput.BackColor = Color.LightCoral;
                    errorProvider.SetError(AddPartInventoryInput, "Inventory must be <= min and >= max");
                    hasExceptions = true;
                }
            }

            return hasExceptions;
        }

        private void HideInputErrors()
        {
            Color backColor = SystemColors.Window;

            AddPartInventoryInput.BackColor = backColor;
            AddPartPriceInput.BackColor = backColor;
            AddPartMinInput.BackColor = backColor;
            AddPartMaxInput.BackColor = backColor;
            AddPartManufactureInput.BackColor = backColor;
            AddPartNameInput.BackColor = backColor;

            errorProvider.SetError(AddPartMaxInput, "");
            errorProvider.SetError(AddPartMinInput, "");
            errorProvider.SetError(AddPartInventoryInput, "");
            errorProvider.SetError(AddPartPriceInput, "");
            errorProvider.SetError(AddPartManufactureInput, "");
            errorProvider.SetError(AddPartNameInput, "");
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
