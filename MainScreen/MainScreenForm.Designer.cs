namespace C968_Ogden;

partial class MainScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        PartTable = new DataGridView();
        PartBindingSource = new BindingSource { DataSource = Inventory.AllParts};
        ProductTable = new DataGridView();
        ProductBindingSource = new BindingSource { DataSource = Inventory.Products};
        PartSearch = new TextBox();
        ProductSearch = new TextBox();
        PartDeleteButton = new Button();
        PartModifyButton = new Button();
        PartAddButton = new Button();
        ProductDeleteButton = new Button();
        ProductModifyButton = new Button();
        ProductAddButton = new Button();
        PartTableLabel = new Label();
        ProductTableLabel = new Label();
        IMSLabel = new Label();
        MainExitButton = new Button();
        PartSearchButton = new Button();
        ProductSearchButton = new Button();
        ((System.ComponentModel.ISupportInitialize)PartTable).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PartBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ProductTable).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ProductBindingSource).BeginInit();
        SuspendLayout();
        // 
        // PartTable
        // 
        PartTable.AllowUserToAddRows = false;
        PartTable.AllowUserToDeleteRows = false;
        PartTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        PartTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        PartTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PartTable.DataSource = PartBindingSource;
        PartTable.Location = new Point(28, 105);
        PartTable.MultiSelect = false;
        PartTable.Name = "PartTable";
        PartTable.ReadOnly = true;
        PartTable.RowHeadersVisible = false;
        PartTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        PartTable.Size = new Size(450, 200);
        PartTable.TabIndex = 0;
        // 
        // ProductTable
        // 
        ProductTable.AllowUserToAddRows = false;
        ProductTable.AllowUserToDeleteRows = false;
        ProductTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        ProductTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        ProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ProductTable.DataSource = ProductBindingSource;
        ProductTable.Location = new Point(506, 105);
        ProductTable.MultiSelect = false;
        ProductTable.Name = "ProductTable";
        ProductTable.ReadOnly = true;
        ProductTable.RowHeadersVisible = false;
        ProductTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ProductTable.Size = new Size(450, 200);
        ProductTable.TabIndex = 1;
        // 
        // PartSearch
        // 
        PartSearch.Location = new Point(328, 76);
        PartSearch.Name = "PartSearch";
        PartSearch.PlaceholderText = "Search...";
        PartSearch.Size = new Size(150, 23);
        PartSearch.TabIndex = 2;
        PartSearch.KeyDown += PartSearchEnter;
        // 
        // ProductSearch
        // 
        ProductSearch.Location = new Point(806, 76);
        ProductSearch.Name = "ProductSearch";
        ProductSearch.PlaceholderText = "Search...";
        ProductSearch.Size = new Size(150, 23);
        ProductSearch.TabIndex = 3;
        // 
        // PartDeleteButton
        // 
        PartDeleteButton.Location = new Point(403, 311);
        PartDeleteButton.Name = "PartDeleteButton";
        PartDeleteButton.Size = new Size(75, 23);
        PartDeleteButton.TabIndex = 6;
        PartDeleteButton.Text = "Delete";
        PartDeleteButton.UseVisualStyleBackColor = true;
        PartDeleteButton.Click += PartDeleteButton_Click;
        // 
        // PartModifyButton
        // 
        PartModifyButton.Location = new Point(322, 311);
        PartModifyButton.Name = "PartModifyButton";
        PartModifyButton.Size = new Size(75, 23);
        PartModifyButton.TabIndex = 7;
        PartModifyButton.Text = "Modify";
        PartModifyButton.UseVisualStyleBackColor = true;
        PartModifyButton.Click += PartModifyButton_Click;
        // 
        // PartAddButton
        // 
        PartAddButton.Location = new Point(241, 311);
        PartAddButton.Name = "PartAddButton";
        PartAddButton.Size = new Size(75, 23);
        PartAddButton.TabIndex = 8;
        PartAddButton.Text = "Add";
        PartAddButton.UseVisualStyleBackColor = true;
        PartAddButton.Click += PartAddButton_Click;
        // 
        // ProductDeleteButton
        // 
        ProductDeleteButton.Location = new Point(881, 311);
        ProductDeleteButton.Name = "ProductDeleteButton";
        ProductDeleteButton.Size = new Size(75, 23);
        ProductDeleteButton.TabIndex = 9;
        ProductDeleteButton.Text = "Delete";
        ProductDeleteButton.UseVisualStyleBackColor = true;
        ProductDeleteButton.Click += ProductDeleteButton_Click;
        // 
        // ProductModifyButton
        // 
        ProductModifyButton.Location = new Point(800, 311);
        ProductModifyButton.Name = "ProductModifyButton";
        ProductModifyButton.Size = new Size(75, 23);
        ProductModifyButton.TabIndex = 10;
        ProductModifyButton.Text = "Modify";
        ProductModifyButton.UseVisualStyleBackColor = true;
        ProductModifyButton.Click += ProductModifyButton_Click;
        // 
        // ProductAddButton
        // 
        ProductAddButton.Location = new Point(719, 311);
        ProductAddButton.Name = "ProductAddButton";
        ProductAddButton.Size = new Size(75, 23);
        ProductAddButton.TabIndex = 11;
        ProductAddButton.Text = "Add";
        ProductAddButton.UseVisualStyleBackColor = true;
        ProductAddButton.Click += ProductAddButton_Click;
        // 
        // PartTableLabel
        // 
        PartTableLabel.AutoSize = true;
        PartTableLabel.BackColor = Color.Transparent;
        PartTableLabel.Font = new Font("Segoe UI", 15F);
        PartTableLabel.ForeColor = SystemColors.ControlText;
        PartTableLabel.Location = new Point(28, 76);
        PartTableLabel.Name = "PartTableLabel";
        PartTableLabel.Size = new Size(54, 28);
        PartTableLabel.TabIndex = 12;
        PartTableLabel.Text = "Parts";
        PartTableLabel.TextAlign = ContentAlignment.BottomLeft;
        // 
        // ProductTableLabel
        // 
        ProductTableLabel.AutoSize = true;
        ProductTableLabel.BackColor = Color.Transparent;
        ProductTableLabel.Font = new Font("Segoe UI", 15F);
        ProductTableLabel.ForeColor = SystemColors.ControlText;
        ProductTableLabel.Location = new Point(506, 76);
        ProductTableLabel.Name = "ProductTableLabel";
        ProductTableLabel.Size = new Size(89, 28);
        ProductTableLabel.TabIndex = 13;
        ProductTableLabel.Text = "Products";
        ProductTableLabel.TextAlign = ContentAlignment.BottomLeft;
        // 
        // IMSLabel
        // 
        IMSLabel.AutoSize = true;
        IMSLabel.Font = new Font("Segoe UI", 15F);
        IMSLabel.Location = new Point(28, 9);
        IMSLabel.Name = "IMSLabel";
        IMSLabel.Size = new Size(283, 28);
        IMSLabel.TabIndex = 14;
        IMSLabel.Text = "Inventory Management System";
        // 
        // MainExitButton
        // 
        MainExitButton.Location = new Point(881, 365);
        MainExitButton.Name = "MainExitButton";
        MainExitButton.Size = new Size(75, 23);
        MainExitButton.TabIndex = 15;
        MainExitButton.Text = "Exit";
        MainExitButton.UseVisualStyleBackColor = true;
        MainExitButton.Click += MainExitButton_Click;
        // 
        // PartSearchButton
        // 
        PartSearchButton.Location = new Point(292, 76);
        PartSearchButton.Name = "PartSearchButton";
        PartSearchButton.Size = new Size(30, 23);
        PartSearchButton.TabIndex = 16;
        PartSearchButton.Text = "Go";
        PartSearchButton.UseVisualStyleBackColor = true;
        PartSearchButton.Click += PartSearchButton_Click;
        // 
        // ProductSearchButton
        // 
        ProductSearchButton.Location = new Point(770, 76);
        ProductSearchButton.Name = "ProductSearchButton";
        ProductSearchButton.Size = new Size(30, 23);
        ProductSearchButton.TabIndex = 17;
        ProductSearchButton.Text = "Go";
        ProductSearchButton.UseVisualStyleBackColor = true;
        // 
        // MainScreen
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 411);
        Controls.Add(ProductSearchButton);
        Controls.Add(PartSearchButton);
        Controls.Add(MainExitButton);
        Controls.Add(IMSLabel);
        Controls.Add(ProductTableLabel);
        Controls.Add(PartTableLabel);
        Controls.Add(ProductAddButton);
        Controls.Add(ProductModifyButton);
        Controls.Add(ProductDeleteButton);
        Controls.Add(PartAddButton);
        Controls.Add(PartModifyButton);
        Controls.Add(PartDeleteButton);
        Controls.Add(ProductSearch);
        Controls.Add(PartSearch);
        Controls.Add(ProductTable);
        Controls.Add(PartTable);
        Name = "MainScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Screen";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)PartTable).EndInit();
        ((System.ComponentModel.ISupportInitialize)PartBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)ProductTable).EndInit();
        ((System.ComponentModel.ISupportInitialize)ProductBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView PartTable;
    private DataGridView ProductTable;
    private TextBox PartSearch;
    private TextBox ProductSearch;
    private Button PartDeleteButton;
    private Button PartModifyButton;
    private Button PartAddButton;
    private Button ProductDeleteButton;
    private Button ProductModifyButton;
    private Button ProductAddButton;
    private Label PartTableLabel;
    private Label ProductTableLabel;
    private Label IMSLabel;
    private Button MainExitButton;
    private BindingSource PartBindingSource;
    private BindingSource ProductBindingSource;
    private Button PartSearchButton;
    private Button ProductSearchButton;
}
