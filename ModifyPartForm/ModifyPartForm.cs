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
        }

        private Part PartToModify { get; set; }
        private string PartType { get; set; }
        private int SelectedRowIndex { get; set; }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            ModifyPartIdInput.Text = PartToModify.PartId.ToString();
            ModifyPartNameInput.Text = PartToModify.Name.ToString();
            ModifyPartInventoryInput.Text = PartToModify.InStock.ToString();
            ModifyPartPriceInput.Text = PartToModify.Price.ToString();
            ModifyPartMinInput.Text = PartToModify.Min.ToString();
            ModifyPartMaxInput.Text = PartToModify.Max.ToString();

        }

        private void ModifyPartSave_Click(object sender, EventArgs e)
        {
            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();
            Close();
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
