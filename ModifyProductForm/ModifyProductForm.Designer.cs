using System.ComponentModel;

namespace C968_Ogden
{
    partial class ModifyProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            AddProductCancel = new Button();
            AddProductSave = new Button();
            AssociatedPartsLabel = new Label();
            RemoveAsscPartButton = new Button();
            AssociatedPartsTable = new DataGridView();
            AddProductMaxInput = new TextBox();
            AddProductMinInput = new TextBox();
            AddProductNameInput = new TextBox();
            AddProductInventoryInput = new TextBox();
            AddProductPriceInput = new TextBox();
            AddProductInventoryLabel = new Label();
            AddProductPriceLabel = new Label();
            AddProductMinLabel = new Label();
            AddProductMaxLabel = new Label();
            AddProductNameLabel = new Label();
            AddProductIdInput = new TextBox();
            AddProductIdLabel = new Label();
            AddProductLabel = new Label();
            AddProdAllPartsLabel = new Label();
            AddAssociatePartButton = new Button();
            SearchCandidatePartButton = new Button();
            SearchCandidatePartsInput = new TextBox();
            AllCandidatePartTable = new DataGridView();
            CandidatePartsBindingSource = new BindingSource{DataSource = Inventory.AllParts};
            AssociatedPartsBindingList = new BindingList<Part>();
            ((ISupportInitialize)AssociatedPartsTable).BeginInit();
            ((ISupportInitialize)AllCandidatePartTable).BeginInit();
            ((ISupportInitialize)CandidatePartsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddProductCancel
            // 
            AddProductCancel.Location = new Point(168, 343);
            AddProductCancel.Name = "AddProductCancel";
            AddProductCancel.Size = new Size(51, 23);
            AddProductCancel.TabIndex = 7;
            AddProductCancel.Text = "Cancel";
            AddProductCancel.UseVisualStyleBackColor = true;
            AddProductCancel.Click += AddProductCancel_Click;
            // 
            // AddProductSave
            // 
            AddProductSave.Location = new Point(75, 343);
            AddProductSave.Name = "AddProductSave";
            AddProductSave.Size = new Size(51, 23);
            AddProductSave.TabIndex = 6;
            AddProductSave.Text = "Save";
            AddProductSave.UseVisualStyleBackColor = true;
            AddProductSave.Click += AddProductSave_Click;
            // 
            // AssociatedPartsLabel
            // 
            AssociatedPartsLabel.AutoSize = true;
            AssociatedPartsLabel.BackColor = Color.Transparent;
            AssociatedPartsLabel.Font = new Font("Segoe UI", 15F);
            AssociatedPartsLabel.ForeColor = SystemColors.ControlText;
            AssociatedPartsLabel.Location = new Point(320, 228);
            AssociatedPartsLabel.Name = "AssociatedPartsLabel";
            AssociatedPartsLabel.Size = new Size(153, 28);
            AssociatedPartsLabel.Text = "Associated Parts";
            AssociatedPartsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // RemoveAsscPartButton
            // 
            RemoveAsscPartButton.Location = new Point(695, 401);
            RemoveAsscPartButton.Name = "RemoveAsscPartButton";
            RemoveAsscPartButton.Size = new Size(75, 23);
            RemoveAsscPartButton.Text = "Remove";
            RemoveAsscPartButton.UseVisualStyleBackColor = true;
            RemoveAsscPartButton.Click += RemoveAsscPartButton_Click;
            // 
            // AssociatedPartsTable
            // 
            AssociatedPartsTable.AllowUserToAddRows = false;
            AssociatedPartsTable.AllowUserToDeleteRows = false;
            AssociatedPartsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssociatedPartsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AssociatedPartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedPartsTable.Location = new Point(320, 257);
            AssociatedPartsTable.MultiSelect = false;
            AssociatedPartsTable.Name = "AssociatedPartsTable";
            AssociatedPartsTable.ReadOnly = true;
            AssociatedPartsTable.RowHeadersVisible = false;
            AssociatedPartsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedPartsTable.Size = new Size(450, 138);
            // 
            // AddProductMaxInput
            // 
            AddProductMaxInput.Location = new Point(122, 290);
            AddProductMaxInput.Name = "AddProductMaxInput";
            AddProductMaxInput.Size = new Size(140, 23);
            AddProductMaxInput.TabIndex = 5;
            // 
            // AddProductMinInput
            // 
            AddProductMinInput.Location = new Point(122, 249);
            AddProductMinInput.Name = "AddProductMinInput";
            AddProductMinInput.Size = new Size(140, 23);
            AddProductMinInput.TabIndex = 4;
            // 
            // AddProductNameInput
            // 
            AddProductNameInput.Location = new Point(122, 126);
            AddProductNameInput.Name = "AddProductNameInput";
            AddProductNameInput.Size = new Size(140, 23);
            AddProductNameInput.TabIndex = 1;
            // 
            // AddProductInventoryInput
            // 
            AddProductInventoryInput.Location = new Point(122, 167);
            AddProductInventoryInput.Name = "AddProductInventoryInput";
            AddProductInventoryInput.Size = new Size(140, 23);
            AddProductInventoryInput.TabIndex = 2;
            // 
            // AddProductPriceInput
            // 
            AddProductPriceInput.Location = new Point(122, 208);
            AddProductPriceInput.Name = "AddProductPriceInput";
            AddProductPriceInput.Size = new Size(140, 23);
            AddProductPriceInput.TabIndex = 3;
            // 
            // AddProductInventoryLabel
            // 
            AddProductInventoryLabel.AutoSize = true;
            AddProductInventoryLabel.Location = new Point(32, 171);
            AddProductInventoryLabel.Name = "AddProductInventoryLabel";
            AddProductInventoryLabel.Size = new Size(57, 15);
            AddProductInventoryLabel.Text = "Inventory";
            // 
            // AddProductPriceLabel
            // 
            AddProductPriceLabel.AutoSize = true;
            AddProductPriceLabel.Location = new Point(24, 212);
            AddProductPriceLabel.Name = "AddProductPriceLabel";
            AddProductPriceLabel.Size = new Size(68, 15);
            AddProductPriceLabel.Text = "Price / Cost";
            // 
            // AddProductMinLabel
            // 
            AddProductMinLabel.AutoSize = true;
            AddProductMinLabel.Location = new Point(66, 253);
            AddProductMinLabel.Name = "AddProductMinLabel";
            AddProductMinLabel.Size = new Size(28, 15);
            AddProductMinLabel.Text = "Min";
            // 
            // AddProductMaxLabel
            // 
            AddProductMaxLabel.AutoSize = true;
            AddProductMaxLabel.Location = new Point(63, 294);
            AddProductMaxLabel.Name = "AddProductMaxLabel";
            AddProductMaxLabel.Size = new Size(30, 15);
            AddProductMaxLabel.Text = "Max";
            // 
            // AddProductNameLabel
            // 
            AddProductNameLabel.AutoSize = true;
            AddProductNameLabel.Location = new Point(54, 130);
            AddProductNameLabel.Name = "AddProductNameLabel";
            AddProductNameLabel.Size = new Size(39, 15);
            AddProductNameLabel.Text = "Name";
            // 
            // AddProductIdInput
            // 
            AddProductIdInput.Enabled = false;
            AddProductIdInput.Location = new Point(122, 85);
            AddProductIdInput.Name = "AddProductIdInput";
            AddProductIdInput.Size = new Size(140, 23);
            // 
            // AddProductIdLabel
            // 
            AddProductIdLabel.AutoSize = true;
            AddProductIdLabel.Location = new Point(74, 89);
            AddProductIdLabel.Name = "AddProductIdLabel";
            AddProductIdLabel.Size = new Size(18, 15);
            AddProductIdLabel.Text = "ID";
            // 
            // AddProductLabel
            // 
            AddProductLabel.AutoSize = true;
            AddProductLabel.BackColor = Color.Transparent;
            AddProductLabel.Font = new Font("Segoe UI", 15F);
            AddProductLabel.ForeColor = SystemColors.ControlText;
            AddProductLabel.Location = new Point(12, 9);
            AddProductLabel.Name = "AddProductLabel";
            AddProductLabel.Size = new Size(149, 28);
            AddProductLabel.Text = "Modify Product";
            AddProductLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddProdAllPartsLabel
            // 
            AddProdAllPartsLabel.AutoSize = true;
            AddProdAllPartsLabel.BackColor = Color.Transparent;
            AddProdAllPartsLabel.Font = new Font("Segoe UI", 15F);
            AddProdAllPartsLabel.ForeColor = SystemColors.ControlText;
            AddProdAllPartsLabel.Location = new Point(320, 27);
            AddProdAllPartsLabel.Name = "AddProdAllPartsLabel";
            AddProdAllPartsLabel.Size = new Size(176, 28);
            AddProdAllPartsLabel.Text = "All Candidate Parts";
            AddProdAllPartsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddAssociatePartButton
            // 
            AddAssociatePartButton.Location = new Point(695, 200);
            AddAssociatePartButton.Name = "AddAssociatePartButton";
            AddAssociatePartButton.Size = new Size(75, 23);
            AddAssociatePartButton.Text = "Add";
            AddAssociatePartButton.UseVisualStyleBackColor = true;
            AddAssociatePartButton.Click += AddAssociatePartButton_Click;
            // 
            // SearchCandidatePartButton
            // 
            SearchCandidatePartButton.BackColor = SystemColors.ButtonFace;
            SearchCandidatePartButton.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            SearchCandidatePartButton.FlatAppearance.BorderSize = 2;
            SearchCandidatePartButton.ForeColor = SystemColors.ControlText;
            SearchCandidatePartButton.Location = new Point(584, 27);
            SearchCandidatePartButton.Name = "SearchCandidatePartButton";
            SearchCandidatePartButton.Size = new Size(30, 23);
            SearchCandidatePartButton.Text = "Go";
            SearchCandidatePartButton.UseVisualStyleBackColor = false;
            SearchCandidatePartButton.Click += SearchCandidatePartButton_Click;
            // 
            // SearchCandidatePartsInput
            // 
            SearchCandidatePartsInput.Location = new Point(620, 27);
            SearchCandidatePartsInput.Name = "SearchCandidatePartsInput";
            SearchCandidatePartsInput.PlaceholderText = "Search...";
            SearchCandidatePartsInput.Size = new Size(150, 23);
            SearchCandidatePartsInput.KeyDown += PartSearchEnter;
            // 
            // AllCandidatePartTable
            // 
            AllCandidatePartTable.AllowUserToAddRows = false;
            AllCandidatePartTable.AllowUserToDeleteRows = false;
            AllCandidatePartTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllCandidatePartTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AllCandidatePartTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllCandidatePartTable.DataSource = CandidatePartsBindingSource;
            AllCandidatePartTable.Location = new Point(320, 56);
            AllCandidatePartTable.MultiSelect = false;
            AllCandidatePartTable.Name = "AllCandidatePartTable";
            AllCandidatePartTable.ReadOnly = true;
            AllCandidatePartTable.RowHeadersVisible = false;
            AllCandidatePartTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllCandidatePartTable.Size = new Size(450, 138);
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddProductCancel);
            Controls.Add(AddProductSave);
            Controls.Add(AssociatedPartsLabel);
            Controls.Add(RemoveAsscPartButton);
            Controls.Add(AssociatedPartsTable);
            Controls.Add(AddProductMaxInput);
            Controls.Add(AddProductMinInput);
            Controls.Add(AddProductNameInput);
            Controls.Add(AddProductInventoryInput);
            Controls.Add(AddProductPriceInput);
            Controls.Add(AddProductInventoryLabel);
            Controls.Add(AddProductPriceLabel);
            Controls.Add(AddProductMinLabel);
            Controls.Add(AddProductMaxLabel);
            Controls.Add(AddProductNameLabel);
            Controls.Add(AddProductIdInput);
            Controls.Add(AddProductIdLabel);
            Controls.Add(AddProductLabel);
            Controls.Add(AddProdAllPartsLabel);
            Controls.Add(AddAssociatePartButton);
            Controls.Add(SearchCandidatePartButton);
            Controls.Add(SearchCandidatePartsInput);
            Controls.Add(AllCandidatePartTable);
            Name = "ModifyProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += Form1_Load;
            ((ISupportInitialize)AssociatedPartsTable).EndInit();
            ((ISupportInitialize)AllCandidatePartTable).EndInit();
            ((ISupportInitialize)CandidatePartsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProductCancel;
        private Button AddProductSave;
        private Label AssociatedPartsLabel;
        private Button RemoveAsscPartButton;
        private DataGridView AssociatedPartsTable;
        private TextBox AddProductMaxInput;
        private TextBox AddProductMinInput;
        private TextBox AddProductNameInput;
        private TextBox AddProductInventoryInput;
        private TextBox AddProductPriceInput;
        private Label AddProductInventoryLabel;
        private Label AddProductPriceLabel;
        private Label AddProductMinLabel;
        private Label AddProductMaxLabel;
        private Label AddProductNameLabel;
        private TextBox AddProductIdInput;
        private Label AddProductIdLabel;
        private Label AddProductLabel;
        private Label AddProdAllPartsLabel;
        private Button AddAssociatePartButton;
        private Button SearchCandidatePartButton;
        private TextBox SearchCandidatePartsInput;
        private DataGridView AllCandidatePartTable;
        private BindingSource CandidatePartsBindingSource;
        private BindingList<Part> AssociatedPartsBindingList;
    }
}