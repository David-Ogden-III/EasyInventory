namespace C968_Ogden
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
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

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            AllCandidatePartTable.ClearSelection();
            AssociatedPartsTable.ClearSelection();
        }

        private void AllCandidatePartTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
