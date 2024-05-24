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
        }

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
    }
}
