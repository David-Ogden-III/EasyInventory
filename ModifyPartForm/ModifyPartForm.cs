using System.Diagnostics;

namespace C968_Ogden
{
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm(Part partToModify, string partType, int selectedRowIndex)
        {
            InitializeComponent();
            PartToModify = partToModify;
            PartType = partType;
            SelectedRowIndex = selectedRowIndex;
            IsOutsourced = (partType == "Outsourced");
            errorProvider.BlinkRate = 0;
        }

        private ErrorProvider errorProvider = new();
        private Part PartToModify { get; set; }
        private string PartType { get; set; }
        private int SelectedRowIndex { get; set; }
        private bool IsOutsourced { get; set; }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            ModifyPartIdInput.Text = PartToModify.PartId.ToString();
            ModifyPartNameInput.Text = PartToModify.Name.ToString();
            ModifyPartInventoryInput.Text = PartToModify.InStock.ToString();
            ModifyPartPriceInput.Text = PartToModify.Price.ToString();
            ModifyPartMinInput.Text = PartToModify.Min.ToString();
            ModifyPartMaxInput.Text = PartToModify.Max.ToString();
            ModifyPartManufactureInput.Text = (IsOutsourced ? ((dynamic)PartToModify).CompanyName.ToString() : ((dynamic)PartToModify).MachineId.ToString());

            if (IsOutsourced)
            {
                ModifyPartInHouseRadio.Checked = false;
                ModifyPartOutsourcedRadio.Checked = true;
            }
        }

        private void ModifyPartSave_Click(object sender, EventArgs e)
        {
            bool hasExceptions = ValidateInput();
            if (hasExceptions) return;

            int id = Convert.ToInt32(ModifyPartIdInput.Text);
            string partName = ModifyPartNameInput.Text;
            int inventory = Convert.ToInt32(ModifyPartInventoryInput.Text);
            decimal price = Convert.ToDecimal(ModifyPartPriceInput.Text);
            int min = Convert.ToInt32(ModifyPartMinInput.Text);
            int max = Convert.ToInt32(ModifyPartMaxInput.Text);
            dynamic newPart;

            if (ModifyPartOutsourcedRadio.Checked)
            {
                string compName = ModifyPartManufactureInput.Text;
                newPart = new Outsourced(partName, price, inventory, min, max, compName, id);
            }
            else
            {
                int machineId = Convert.ToInt32(ModifyPartManufactureInput.Text);
                newPart = new InHouse(partName, price, inventory, min, max, machineId, id);
            }
            Inventory.DeletePart(PartToModify);
            Inventory.UpdatePart(SelectedRowIndex, newPart);

            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();
            Close();
            MainScreen.ClearTableSelections();
        }

        private void ModifyPartCancel_Click(object sender, EventArgs e)
        {
            var MainScreen = Tag as MainScreen;
            if (MainScreen != null) Debug.WriteLine(MainScreen.Name);
            MainScreen?.Show();

            Close();
        }

        private void ModifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartOutsourcedRadio.Checked)
            {
                ModifyPartMachineIdLabel.Hide();
                ModifyPartCompanyNameLabel.Show();
            }
        }

        private void ModifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            ModifyPartCompanyNameLabel.Hide();
            ModifyPartMachineIdLabel.Show();
        }




        // Helper Methods - Form Validation
        private bool ValidateInput()
        {
            HideInputErrors();

            bool hasExceptions = false;


            bool inventorySuccess = int.TryParse(ModifyPartInventoryInput.Text, out int inventory);
            if (ModifyPartInventoryInput.Text.Length <= 0)
            {
                InputLengthError(ModifyPartInventoryInput);
                hasExceptions = true;
            }
            else if (!inventorySuccess)
            {
                IntParseError(ModifyPartInventoryInput);
                hasExceptions = true;
            }

            bool priceSuccess = decimal.TryParse(ModifyPartPriceInput.Text, out decimal price);
            if (ModifyPartPriceInput.Text.Length <= 0)
            {
                InputLengthError(ModifyPartPriceInput);
                hasExceptions = true;
            }
            else if (!priceSuccess)
            {
                DecimalParseError(ModifyPartPriceInput);
                hasExceptions = true;
            }

            bool minSuccess = int.TryParse(ModifyPartMinInput.Text, out int min);
            if (ModifyPartMinInput.Text.Length <= 0)
            {
                InputLengthError(ModifyPartMinInput);
                hasExceptions = true;
            }
            else if (!minSuccess)
            {
                IntParseError(ModifyPartMinInput);
                hasExceptions = true;
            }

            bool maxSuccess = int.TryParse(ModifyPartMaxInput.Text, out int max);
            if (ModifyPartMaxInput.Text.Length <= 0)
            {
                InputLengthError(ModifyPartMaxInput);
                hasExceptions = true;
            }
            else if (!maxSuccess)
            {
                IntParseError(ModifyPartMaxInput);
                hasExceptions = true;
            }

            if (ModifyPartNameInput.Text.Length <= 0)
            {
                InputLengthError(ModifyPartNameInput);
                hasExceptions = true;
            }

            if (ModifyPartInHouseRadio.Checked)
            {
                bool machineSuccess = int.TryParse(ModifyPartManufactureInput.Text, out int machine);
                if (ModifyPartManufactureInput.Text.Length <= 0)
                {
                    InputLengthError(ModifyPartManufactureInput);
                    hasExceptions = true;
                }
                else if (!machineSuccess)
                {
                    IntParseError(ModifyPartManufactureInput);
                    hasExceptions = true;
                }
            }
            else if (ModifyPartOutsourcedRadio.Checked)
            {
                if (ModifyPartManufactureInput.Text.Length <= 0)
                {
                    InputLengthError(ModifyPartManufactureInput);
                    hasExceptions = true;
                }
            }


            if (minSuccess && maxSuccess)
            {
                if (min > max)
                {
                    MinMaxBoundsError(ModifyPartMinInput, ModifyPartMaxInput);
                    hasExceptions = true;
                }
                else if (inventorySuccess && (min > inventory || inventory > max))
                {
                    ModifyPartInventoryInput.BackColor = Color.LightCoral;
                    errorProvider.SetError(ModifyPartInventoryInput, "Inventory must be <= min and >= max");
                    hasExceptions = true;
                }
            }

            return hasExceptions;
        }

        private void HideInputErrors()
        {
            Color backColor = SystemColors.Window;

            ModifyPartInventoryInput.BackColor = backColor;
            ModifyPartPriceInput.BackColor = backColor;
            ModifyPartMinInput.BackColor = backColor;
            ModifyPartMaxInput.BackColor = backColor;
            ModifyPartManufactureInput.BackColor = backColor;
            ModifyPartNameInput.BackColor = backColor;

            errorProvider.SetError(ModifyPartMaxInput, "");
            errorProvider.SetError(ModifyPartMinInput, "");
            errorProvider.SetError(ModifyPartInventoryInput, "");
            errorProvider.SetError(ModifyPartPriceInput, "");
            errorProvider.SetError(ModifyPartManufactureInput, "");
            errorProvider.SetError(ModifyPartNameInput, "");
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
