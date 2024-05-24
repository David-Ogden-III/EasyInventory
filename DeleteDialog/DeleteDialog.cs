using System.ComponentModel;
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

        public DeleteDialog(Part partToDelete, BindingList<Part> listDeleteFrom)
        {
            InitializeComponent();
            PartToDelete = partToDelete;
            ListDeleteFrom = listDeleteFrom;
        }

        private Part? PartToDelete { get; set; }
        private int? ProdIndexToDelete { get; set; }
        private BindingList<Part>? ListDeleteFrom { get; set; }

        private void DeleteDialog_Load(object sender, EventArgs e)
        {
            if (PartToDelete != null && ProdIndexToDelete == null && ListDeleteFrom == null)
            {
                DeleteDialogLabel.Location = new Point(102, 9);
                PartDeleteExtraLabel.Visible = true;
            }
        }

        private void DialogDelete_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (PartToDelete != null && ProdIndexToDelete == null && ListDeleteFrom == null)
            {
                foreach (Product prod in Inventory.Products)
                {
                    if (prod.AssociatedParts.Contains(PartToDelete))
                    {
                        prod.AssociatedParts.Remove(PartToDelete);
                        count++;
                    }
                }

                string partName = PartToDelete.Name;
                bool success = Inventory.DeletePart(PartToDelete);

                Debug.WriteLineIf(success, $"{partName} has been successfully deleted and disassociated from {count} Products.");
            }
            else if (PartToDelete == null && ProdIndexToDelete != null && ListDeleteFrom == null)
            {
                int indexToDelete = (int)ProdIndexToDelete;
                Inventory.RemoveProduct(indexToDelete);
            }
            else if (PartToDelete != null && ProdIndexToDelete == null && ListDeleteFrom != null)
            {
                string partName = PartToDelete.Name;
                bool success = ListDeleteFrom.Remove(PartToDelete);
                Debug.WriteLineIf(success, $"{partName} has been successfully deleted.");
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
