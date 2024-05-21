namespace C968_Ogden
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            string idPreview = Part.IdPreview().ToString();
            AddPartIdInput.Text = idPreview;
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            string partName = AddPartNameInput.Text;
            int inventory = Convert.ToInt32(AddPartInventoryInput.Text);
            decimal price = Convert.ToDecimal(AddPartPriceInput.Text);
            int min = Convert.ToInt32(AddPartMinInput.Text);
            int max = Convert.ToInt32(AddPartMaxInput.Text);
            dynamic newPart;

            if (OutsourcedRadio.Checked)
            {
                string compName = AddPartCompanyInput.Text;
                newPart = new Outsourced(partName, price, inventory, min, max, compName);
            }
            else
            {
                int machineId = Convert.ToInt32(AddPartMachineIdInput.Text);
                newPart = new InHouse(partName, price, inventory, min, max, machineId);
            }
            Inventory.AllParts.Add(newPart);

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
            AddPartMachineIdInput.Hide();
            AddPartMachineIdLabel.Hide();
            AddPartCompanyInput.Show();
            AddPartCompanyNameLabel.Show();
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartCompanyInput.Hide();
            AddPartCompanyNameLabel.Hide();
            AddPartMachineIdInput.Show();
            AddPartMachineIdLabel.Show();
        }
    }
}
