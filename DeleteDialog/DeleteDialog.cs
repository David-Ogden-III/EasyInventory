using System.Diagnostics;

namespace C968_Ogden
{
    public partial class DeleteDialog : Form
    {
        public DeleteDialog(Part partToDelete)
        {
            InitializeComponent();
            PartToDelete = partToDelete;
        }

        public DeleteDialog(int prodIndexToDelete)
        {
            InitializeComponent();
            ProdIndexToDelete = prodIndexToDelete;
        }

        private Part? PartToDelete { get; set; }
        private int? ProdIndexToDelete { get; set; }

        private void DeleteDialog_Load(object sender, EventArgs e)
        {

        }

        private void DialogDelete_Click(object sender, EventArgs e)
        {
            if (PartToDelete != null && ProdIndexToDelete == null)
            {
                string partName = PartToDelete.Name;
                bool success = Inventory.DeletePart(PartToDelete);
                Debug.WriteLineIf(success, $"{partName} has been successfully deleted.");
            }
            else if (ProdIndexToDelete != null && PartToDelete == null)
            {
                Inventory.RemoveProduct((int)ProdIndexToDelete);
            }
            else
            {
                Debug.WriteLine("There was an issue deleting the item.");
            }
            Close();
        }

        private void DialogCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
