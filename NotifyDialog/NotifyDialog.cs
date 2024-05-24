namespace C968_Ogden
{
    public partial class NotifyDialog : Form
    {
        public NotifyDialog()
        {
            InitializeComponent();
        }

        public NotifyDialog(string notifyType)
        {
            InitializeComponent();
            NotifyType = notifyType;
        }

        public void NotifyDialog_Load(object sender, EventArgs e)
        {
            if (NotifyType == "NotifyProduct")
            {
                NotFoundLabel.Visible = false;
                ProdHasParts.Visible = true;
            }
            else if (NotifyType == "NotifyPart")
            {
                NotFoundLabel.Visible = false;
                PartStillAssociated.Visible = true;
            }
        }

        private string? NotifyType { get; set; }

        private void NotFoundOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
