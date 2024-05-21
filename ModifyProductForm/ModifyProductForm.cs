namespace C968_Ogden
{
    public partial class ModifyProductForm : Form
    {
        public ModifyProductForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            var MainScreen = Tag as MainScreen;
            MainScreen?.Show();

            Close();
        }
    }
}
