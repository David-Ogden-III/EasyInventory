namespace C968_Ogden;

public partial class MainScreen : Form
{
    public MainScreen()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        DeleteDialog dialog = new();
        dialog.ShowDialog();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        ModifyPartForm modifyPartForm = new()
        {
            Tag = this
        };
        modifyPartForm.Show(this);
        Hide();
    }

    private void PartAddButton_Click(object sender, EventArgs e)
    {
        AddPartForm addPartForm = new()
        {
            Tag = this
        };
        addPartForm.Show(this);
        Hide();
    }

    private void MainExitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void PartSearch_TextChanged(object sender, EventArgs e)
    {

    }

    private void ProductAddButton_Click(object sender, EventArgs e)
    {
        AddProductForm addProductForm = new()
        {
            Tag = this
        };
        addProductForm.Show(this);
        Hide();
    }

    private void ProductModifyButton_Click(object sender, EventArgs e)
    {
        ModifyProductForm modifyProductForm = new()
        {
            Tag = this
        };
        modifyProductForm.Show(this);
        Hide();
    }

    private void ProductDeleteButton_Click(object sender, EventArgs e)
    {
        DeleteDialog dialog = new();
        dialog.ShowDialog();
    }
}
