namespace C968_Ogden
{
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
        }
        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

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
            MainScreen?.Show();

            Close();
        }

        private void ModifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartOutsourcedRadio.Checked)
            {
                ModifyPartMachineIdInput.Hide();
                ModifyPartMachineIdLabel.Hide();
                ModifyPartCompanyInput.Show();
                ModifyPartCompanyNameLabel.Show();
            }
        }

        private void ModifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            ModifyPartCompanyInput.Hide();
            ModifyPartCompanyNameLabel.Hide();
            ModifyPartMachineIdInput.Show();
            ModifyPartMachineIdLabel.Show();
        }
    }
}
