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

        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
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
            if (OutsourcedRadio.Checked)
            {
                AddPartMachineIdInput.Hide();
                AddPartMachineIdLabel.Hide();
                AddPartCompanyInput.Show();
                AddPartCompanyNameLabel.Show();
            }
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
