namespace C968_Ogden
{
    partial class AddProductForm
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
            AddProdAllPartsLabel = new Label();
            AddAssociatePartButton = new Button();
            SearchCandidatePartButton = new Button();
            SearchCandidatePartsInput = new TextBox();
            AllCandidatePartTable = new DataGridView();
            partID = new DataGridViewTextBoxColumn();
            partName = new DataGridViewTextBoxColumn();
            partInventory = new DataGridViewTextBoxColumn();
            partPrice = new DataGridViewTextBoxColumn();
            partMin = new DataGridViewTextBoxColumn();
            partMax = new DataGridViewTextBoxColumn();
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
            AssociatedPartsLabel = new Label();
            RemoveAsscPartButton = new Button();
            AssociatedPartsTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            AddProductCancel = new Button();
            AddProductSave = new Button();
            ((System.ComponentModel.ISupportInitialize)AllCandidatePartTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsTable).BeginInit();
            SuspendLayout();
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
            AddProdAllPartsLabel.TabIndex = 19;
            AddProdAllPartsLabel.Text = "All Candidate Parts";
            AddProdAllPartsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddAssociatePartButton
            // 
            AddAssociatePartButton.Location = new Point(695, 200);
            AddAssociatePartButton.Name = "AddAssociatePartButton";
            AddAssociatePartButton.Size = new Size(75, 23);
            AddAssociatePartButton.TabIndex = 18;
            AddAssociatePartButton.Text = "Add";
            AddAssociatePartButton.UseVisualStyleBackColor = true;
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
            SearchCandidatePartButton.TabIndex = 15;
            SearchCandidatePartButton.Text = "Go";
            SearchCandidatePartButton.UseVisualStyleBackColor = false;
            // 
            // SearchCandidatePartsInput
            // 
            SearchCandidatePartsInput.Location = new Point(620, 27);
            SearchCandidatePartsInput.Name = "SearchCandidatePartsInput";
            SearchCandidatePartsInput.PlaceholderText = "Search...";
            SearchCandidatePartsInput.Size = new Size(150, 23);
            SearchCandidatePartsInput.TabIndex = 14;
            // 
            // AllCandidatePartTable
            // 
            AllCandidatePartTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllCandidatePartTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AllCandidatePartTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllCandidatePartTable.Columns.AddRange(new DataGridViewColumn[] { partID, partName, partInventory, partPrice, partMin, partMax });
            AllCandidatePartTable.Location = new Point(320, 56);
            AllCandidatePartTable.MultiSelect = false;
            AllCandidatePartTable.Name = "AllCandidatePartTable";
            AllCandidatePartTable.RowHeadersVisible = false;
            AllCandidatePartTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllCandidatePartTable.Size = new Size(450, 138);
            AllCandidatePartTable.TabIndex = 13;
            // 
            // partID
            // 
            partID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partID.HeaderText = "Part ID";
            partID.Name = "partID";
            // 
            // partName
            // 
            partName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partName.HeaderText = "Name";
            partName.Name = "partName";
            // 
            // partInventory
            // 
            partInventory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partInventory.HeaderText = "Inventory";
            partInventory.Name = "partInventory";
            // 
            // partPrice
            // 
            partPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partPrice.HeaderText = "Price";
            partPrice.Name = "partPrice";
            // 
            // partMin
            // 
            partMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partMin.HeaderText = "Min";
            partMin.Name = "partMin";
            // 
            // partMax
            // 
            partMax.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partMax.HeaderText = "Max";
            partMax.Name = "partMax";
            // 
            // AddProductMaxInput
            // 
            AddProductMaxInput.Location = new Point(122, 290);
            AddProductMaxInput.Name = "AddProductMaxInput";
            AddProductMaxInput.Size = new Size(140, 23);
            AddProductMaxInput.TabIndex = 42;
            // 
            // AddProductMinInput
            // 
            AddProductMinInput.Location = new Point(122, 249);
            AddProductMinInput.Name = "AddProductMinInput";
            AddProductMinInput.Size = new Size(140, 23);
            AddProductMinInput.TabIndex = 41;
            // 
            // AddProductNameInput
            // 
            AddProductNameInput.Location = new Point(122, 126);
            AddProductNameInput.Name = "AddProductNameInput";
            AddProductNameInput.Size = new Size(140, 23);
            AddProductNameInput.TabIndex = 40;
            // 
            // AddProductInventoryInput
            // 
            AddProductInventoryInput.Location = new Point(122, 167);
            AddProductInventoryInput.Name = "AddProductInventoryInput";
            AddProductInventoryInput.Size = new Size(140, 23);
            AddProductInventoryInput.TabIndex = 39;
            // 
            // AddProductPriceInput
            // 
            AddProductPriceInput.Location = new Point(122, 208);
            AddProductPriceInput.Name = "AddProductPriceInput";
            AddProductPriceInput.Size = new Size(140, 23);
            AddProductPriceInput.TabIndex = 38;
            // 
            // AddProductInventoryLabel
            // 
            AddProductInventoryLabel.AutoSize = true;
            AddProductInventoryLabel.Location = new Point(32, 171);
            AddProductInventoryLabel.Name = "AddProductInventoryLabel";
            AddProductInventoryLabel.Size = new Size(57, 15);
            AddProductInventoryLabel.TabIndex = 37;
            AddProductInventoryLabel.Text = "Inventory";
            // 
            // AddProductPriceLabel
            // 
            AddProductPriceLabel.AutoSize = true;
            AddProductPriceLabel.Location = new Point(24, 212);
            AddProductPriceLabel.Name = "AddProductPriceLabel";
            AddProductPriceLabel.Size = new Size(68, 15);
            AddProductPriceLabel.TabIndex = 36;
            AddProductPriceLabel.Text = "Price / Cost";
            // 
            // AddProductMinLabel
            // 
            AddProductMinLabel.AutoSize = true;
            AddProductMinLabel.Location = new Point(66, 253);
            AddProductMinLabel.Name = "AddProductMinLabel";
            AddProductMinLabel.Size = new Size(28, 15);
            AddProductMinLabel.TabIndex = 35;
            AddProductMinLabel.Text = "Min";
            // 
            // AddProductMaxLabel
            // 
            AddProductMaxLabel.AutoSize = true;
            AddProductMaxLabel.Location = new Point(63, 294);
            AddProductMaxLabel.Name = "AddProductMaxLabel";
            AddProductMaxLabel.Size = new Size(30, 15);
            AddProductMaxLabel.TabIndex = 34;
            AddProductMaxLabel.Text = "Max";
            // 
            // AddProductNameLabel
            // 
            AddProductNameLabel.AutoSize = true;
            AddProductNameLabel.Location = new Point(54, 130);
            AddProductNameLabel.Name = "AddProductNameLabel";
            AddProductNameLabel.Size = new Size(39, 15);
            AddProductNameLabel.TabIndex = 33;
            AddProductNameLabel.Text = "Name";
            // 
            // AddProductIdInput
            // 
            AddProductIdInput.Enabled = false;
            AddProductIdInput.Location = new Point(122, 85);
            AddProductIdInput.Name = "AddProductIdInput";
            AddProductIdInput.Size = new Size(140, 23);
            AddProductIdInput.TabIndex = 32;
            // 
            // AddProductIdLabel
            // 
            AddProductIdLabel.AutoSize = true;
            AddProductIdLabel.Location = new Point(74, 89);
            AddProductIdLabel.Name = "AddProductIdLabel";
            AddProductIdLabel.Size = new Size(18, 15);
            AddProductIdLabel.TabIndex = 31;
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
            AddProductLabel.Size = new Size(123, 28);
            AddProductLabel.TabIndex = 30;
            AddProductLabel.Text = "Add Product";
            AddProductLabel.TextAlign = ContentAlignment.BottomLeft;
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
            AssociatedPartsLabel.TabIndex = 47;
            AssociatedPartsLabel.Text = "Associated Parts";
            AssociatedPartsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // RemoveAsscPartButton
            // 
            RemoveAsscPartButton.Location = new Point(695, 401);
            RemoveAsscPartButton.Name = "RemoveAsscPartButton";
            RemoveAsscPartButton.Size = new Size(75, 23);
            RemoveAsscPartButton.TabIndex = 46;
            RemoveAsscPartButton.Text = "Remove";
            RemoveAsscPartButton.UseVisualStyleBackColor = true;
            // 
            // AssociatedPartsTable
            // 
            AssociatedPartsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssociatedPartsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AssociatedPartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedPartsTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            AssociatedPartsTable.Location = new Point(320, 257);
            AssociatedPartsTable.MultiSelect = false;
            AssociatedPartsTable.Name = "AssociatedPartsTable";
            AssociatedPartsTable.RowHeadersVisible = false;
            AssociatedPartsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedPartsTable.Size = new Size(450, 138);
            AssociatedPartsTable.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Min";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Max";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // AddProductCancel
            // 
            AddProductCancel.Location = new Point(168, 343);
            AddProductCancel.Name = "AddProductCancel";
            AddProductCancel.Size = new Size(51, 23);
            AddProductCancel.TabIndex = 49;
            AddProductCancel.Text = "Cancel";
            AddProductCancel.UseVisualStyleBackColor = true;
            AddProductCancel.Click += AddProductCancel_Click;
            // 
            // AddProductSave
            // 
            AddProductSave.Location = new Point(75, 343);
            AddProductSave.Name = "AddProductSave";
            AddProductSave.Size = new Size(51, 23);
            AddProductSave.TabIndex = 48;
            AddProductSave.Text = "Save";
            AddProductSave.UseVisualStyleBackColor = true;
            AddProductSave.Click += AddProductSave_Click;
            // 
            // AddProductForm
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
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)AllCandidatePartTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProdAllPartsLabel;
        private Button AddAssociatePartButton;
        private Button SearchCandidatePartButton;
        private TextBox SearchCandidatePartsInput;
        private DataGridView AllCandidatePartTable;
        private DataGridViewTextBoxColumn partID;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn partMin;
        private DataGridViewTextBoxColumn partMax;
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
        private Label AssociatedPartsLabel;
        private Button RemoveAsscPartButton;
        private DataGridView AssociatedPartsTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button AddProductCancel;
        private Button AddProductSave;
    }
}