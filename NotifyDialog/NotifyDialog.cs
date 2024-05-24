namespace C968_Ogden
{
    public partial class NotifyDialog : Form
    {
        public NotifyDialog()
        {
            InitializeComponent();
        }

        public NotifyDialog(string mainScreen)
        {
            InitializeComponent();
            MainScreen = mainScreen;
        }

        public void NotifyDialog_Load(object sender, EventArgs e)
        {
            if (MainScreen != null)
            {
                NotFoundLabel.Visible = false;
                ProdHasParts.Visible = true;
            }
        }

        private string? MainScreen { get; set; }

        private void NotFoundOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
