using System.Diagnostics;

namespace C968_Ogden
{
    public partial class DeleteDialog : Form
    {
        public DeleteDialog(Part? partToDelete = null, Product? productToDelete = null)
        {
            InitializeComponent();
            PartToDelete = partToDelete;
            ProductToDelete = productToDelete;
        }

        private Part? PartToDelete { get; set; }
        private Product? ProductToDelete { get; set; }

        private void DeleteDialog_Load(object sender, EventArgs e)
        {

        }

        private void DialogDelete_Click(object sender, EventArgs e)
        {
            if (PartToDelete != null)
            {
                string partName = PartToDelete.Name;
                bool success = Inventory.DeletePart(PartToDelete);
                Debug.WriteLineIf(success, $"{partName} has been successfully deleted.");
            }
            else
            {

            }
            Close();
        }

        private void DialogCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
