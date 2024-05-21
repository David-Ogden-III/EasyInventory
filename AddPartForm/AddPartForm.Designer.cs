namespace C968_Ogden
{
    partial class AddPartForm
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
            InHouseRadio = new RadioButton();
            OutsourcedRadio = new RadioButton();
            AddPartLabel = new Label();
            AddPartIdLabel = new Label();
            AddPartIdInput = new TextBox();
            AddPartNameLabel = new Label();
            AddPartMachineIdLabel = new Label();
            AddPartMaxLabel = new Label();
            AddPartMinLabel = new Label();
            AddPartPriceLabel = new Label();
            AddPartInventoryLabel = new Label();
            AddPartPriceInput = new TextBox();
            AddPartManufactureInput = new TextBox();
            AddPartInventoryInput = new TextBox();
            AddPartNameInput = new TextBox();
            AddPartMinInput = new TextBox();
            AddPartMaxInput = new TextBox();
            AddPartSave = new Button();
            AddPartCancel = new Button();
            AddPartCompanyNameLabel = new Label();
            SuspendLayout();
            // 
            // InHouseRadio
            // 
            InHouseRadio.AutoSize = true;
            InHouseRadio.Checked = true;
            InHouseRadio.Location = new Point(108, 55);
            InHouseRadio.Name = "InHouseRadio";
            InHouseRadio.Size = new Size(76, 19);
            InHouseRadio.TabIndex = 0;
            InHouseRadio.TabStop = true;
            InHouseRadio.Text = "In-House";
            InHouseRadio.UseVisualStyleBackColor = true;
            InHouseRadio.CheckedChanged += InHouseRadio_CheckedChanged;
            // 
            // OutsourcedRadio
            // 
            OutsourcedRadio.AutoSize = true;
            OutsourcedRadio.Location = new Point(206, 55);
            OutsourcedRadio.Name = "OutsourcedRadio";
            OutsourcedRadio.Size = new Size(90, 19);
            OutsourcedRadio.TabIndex = 1;
            OutsourcedRadio.Text = "Outsourced";
            OutsourcedRadio.UseVisualStyleBackColor = true;
            OutsourcedRadio.CheckedChanged += OutsourcedRadio_CheckedChanged;
            // 
            // AddPartLabel
            // 
            AddPartLabel.AutoSize = true;
            AddPartLabel.BackColor = Color.Transparent;
            AddPartLabel.Font = new Font("Segoe UI", 15F);
            AddPartLabel.ForeColor = SystemColors.ControlText;
            AddPartLabel.Location = new Point(12, 9);
            AddPartLabel.Name = "AddPartLabel";
            AddPartLabel.Size = new Size(88, 28);
            AddPartLabel.Text = "Add Part";
            AddPartLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddPartIdLabel
            // 
            AddPartIdLabel.AutoSize = true;
            AddPartIdLabel.Location = new Point(129, 100);
            AddPartIdLabel.Name = "AddPartIdLabel";
            AddPartIdLabel.Size = new Size(20, 15);
            AddPartIdLabel.Text = "ID";
            // 
            // AddPartIdInput
            // 
            AddPartIdInput.Enabled = false;
            AddPartIdInput.Location = new Point(177, 96);
            AddPartIdInput.Name = "AddPartIdInput";
            AddPartIdInput.Size = new Size(140, 23);
            // 
            // AddPartNameLabel
            // 
            AddPartNameLabel.AutoSize = true;
            AddPartNameLabel.Location = new Point(109, 141);
            AddPartNameLabel.Name = "AddPartNameLabel";
            AddPartNameLabel.Size = new Size(40, 15);
            AddPartNameLabel.Text = "Name";
            // 
            // AddPartMachineIdLabel
            // 
            AddPartMachineIdLabel.AutoSize = true;
            AddPartMachineIdLabel.Location = new Point(79, 346);
            AddPartMachineIdLabel.Name = "AddPartMachineIdLabel";
            AddPartMachineIdLabel.Size = new Size(70, 15);
            AddPartMachineIdLabel.Text = "Machine ID";
            // 
            // AddPartMaxLabel
            // 
            AddPartMaxLabel.AutoSize = true;
            AddPartMaxLabel.Location = new Point(118, 305);
            AddPartMaxLabel.Name = "AddPartMaxLabel";
            AddPartMaxLabel.Size = new Size(31, 15);
            AddPartMaxLabel.Text = "Max";
            // 
            // AddPartMinLabel
            // 
            AddPartMinLabel.AutoSize = true;
            AddPartMinLabel.Location = new Point(121, 264);
            AddPartMinLabel.Name = "AddPartMinLabel";
            AddPartMinLabel.Size = new Size(28, 15);
            AddPartMinLabel.Text = "Min";
            // 
            // AddPartPriceLabel
            // 
            AddPartPriceLabel.AutoSize = true;
            AddPartPriceLabel.Location = new Point(79, 223);
            AddPartPriceLabel.Name = "AddPartPriceLabel";
            AddPartPriceLabel.Size = new Size(70, 15);
            AddPartPriceLabel.Text = "Price / Cost";
            // 
            // AddPartInventoryLabel
            // 
            AddPartInventoryLabel.AutoSize = true;
            AddPartInventoryLabel.Location = new Point(87, 182);
            AddPartInventoryLabel.Name = "AddPartInventoryLabel";
            AddPartInventoryLabel.Size = new Size(62, 15);
            AddPartInventoryLabel.Text = "Inventory";
            // 
            // AddPartPriceInput
            // 
            AddPartPriceInput.Location = new Point(177, 219);
            AddPartPriceInput.Name = "AddPartPriceInput";
            AddPartPriceInput.Size = new Size(140, 23);
            AddPartPriceInput.TabIndex = 4;
            // 
            // AddPartManufactureInput
            // 
            AddPartManufactureInput.Location = new Point(177, 342);
            AddPartManufactureInput.Name = "AddPartManufactureInput";
            AddPartManufactureInput.Size = new Size(140, 23);
            AddPartManufactureInput.TabIndex = 7;
            // 
            // AddPartInventoryInput
            // 
            AddPartInventoryInput.Location = new Point(177, 178);
            AddPartInventoryInput.Name = "AddPartInventoryInput";
            AddPartInventoryInput.Size = new Size(140, 23);
            AddPartInventoryInput.TabIndex = 3;
            // 
            // AddPartNameInput
            // 
            AddPartNameInput.Location = new Point(177, 137);
            AddPartNameInput.Name = "AddPartNameInput";
            AddPartNameInput.Size = new Size(140, 23);
            AddPartNameInput.TabIndex = 2;
            // 
            // AddPartMinInput
            // 
            AddPartMinInput.Location = new Point(177, 260);
            AddPartMinInput.Name = "AddPartMinInput";
            AddPartMinInput.Size = new Size(140, 23);
            AddPartMinInput.TabIndex = 5;
            // 
            // AddPartMaxInput
            // 
            AddPartMaxInput.Location = new Point(177, 301);
            AddPartMaxInput.Name = "AddPartMaxInput";
            AddPartMaxInput.Size = new Size(140, 23);
            AddPartMaxInput.TabIndex = 6;
            // 
            // AddPartSave
            // 
            AddPartSave.Location = new Point(130, 395);
            AddPartSave.Name = "AddPartSave";
            AddPartSave.Size = new Size(51, 23);
            AddPartSave.TabIndex = 8;
            AddPartSave.Text = "Save";
            AddPartSave.UseVisualStyleBackColor = true;
            AddPartSave.Click += AddPartSave_Click;
            // 
            // AddPartCancel
            // 
            AddPartCancel.Location = new Point(223, 395);
            AddPartCancel.Name = "AddPartCancel";
            AddPartCancel.Size = new Size(51, 23);
            AddPartCancel.TabIndex = 9;
            AddPartCancel.Text = "Cancel";
            AddPartCancel.UseVisualStyleBackColor = true;
            AddPartCancel.Click += AddPartCancel_Click;
            // 
            // AddPartCompanyNameLabel
            // 
            AddPartCompanyNameLabel.AutoSize = true;
            AddPartCompanyNameLabel.Location = new Point(55, 346);
            AddPartCompanyNameLabel.Name = "AddPartCompanyNameLabel";
            AddPartCompanyNameLabel.Size = new Size(94, 15);
            AddPartCompanyNameLabel.Text = "Company Name";
            AddPartCompanyNameLabel.Visible = false;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(AddPartCancel);
            Controls.Add(AddPartSave);
            Controls.Add(AddPartMaxInput);
            Controls.Add(AddPartMinInput);
            Controls.Add(AddPartNameInput);
            Controls.Add(AddPartInventoryInput);
            Controls.Add(AddPartManufactureInput);
            Controls.Add(AddPartPriceInput);
            Controls.Add(AddPartInventoryLabel);
            Controls.Add(AddPartPriceLabel);
            Controls.Add(AddPartMinLabel);
            Controls.Add(AddPartMaxLabel);
            Controls.Add(AddPartNameLabel);
            Controls.Add(AddPartIdInput);
            Controls.Add(AddPartIdLabel);
            Controls.Add(AddPartLabel);
            Controls.Add(OutsourcedRadio);
            Controls.Add(InHouseRadio);
            Controls.Add(AddPartMachineIdLabel);
            Controls.Add(AddPartCompanyNameLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "AddPartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Part";
            Load += AddPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton InHouseRadio;
        private RadioButton OutsourcedRadio;
        private Label AddPartLabel;
        private Label AddPartIdLabel;
        private TextBox AddPartIdInput;
        private Label AddPartNameLabel;
        private Label AddPartMachineIdLabel;
        private Label AddPartMaxLabel;
        private Label AddPartMinLabel;
        private Label AddPartPriceLabel;
        private Label AddPartInventoryLabel;
        private TextBox AddPartPriceInput;
        private TextBox AddPartManufactureInput;
        private TextBox AddPartInventoryInput;
        private TextBox AddPartNameInput;
        private TextBox AddPartMinInput;
        private TextBox AddPartMaxInput;
        private Button AddPartSave;
        private Button AddPartCancel;
        private Label AddPartCompanyNameLabel;
    }
}