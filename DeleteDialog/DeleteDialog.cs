namespace C968_Ogden
{
    public partial class DeleteDialog : Form
    {
        public DeleteDialog()
        {
            InitializeComponent();
        }

        private void DeleteDialog_Load(object sender, EventArgs e)
        {

        }

        private void DialogDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
