namespace C968_Ogden
{
    partial class ModifyPartForm
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
            ModifyPartCompanyInput = new TextBox();
            ModifyPartCancel = new Button();
            ModifyPartSave = new Button();
            ModifyPartMaxInput = new TextBox();
            ModifyPartMinInput = new TextBox();
            ModifyPartNameInput = new TextBox();
            ModifyPartInventoryInput = new TextBox();
            ModifyPartMachineIdInput = new TextBox();
            ModifyPartPriceInput = new TextBox();
            ModifyPartInventoryLabel = new Label();
            ModifyPartPriceLabel = new Label();
            ModifyPartMinLabel = new Label();
            ModifyPartMaxLabel = new Label();
            ModifyPartNameLabel = new Label();
            ModifyPartIdInput = new TextBox();
            ModifyPartIdLabel = new Label();
            ModifyPartLabel = new Label();
            ModifyPartOutsourcedRadio = new RadioButton();
            ModifyPartInHouseRadio = new RadioButton();
            ModifyPartMachineIdLabel = new Label();
            ModifyPartCompanyNameLabel = new Label();
            SuspendLayout();
            // 
            // ModifyPartCompanyInput
            // 
            ModifyPartCompanyInput.Location = new Point(177, 342);
            ModifyPartCompanyInput.Name = "ModifyPartCompanyInput";
            ModifyPartCompanyInput.Size = new Size(140, 23);
            ModifyPartCompanyInput.TabIndex = 52;
            ModifyPartCompanyInput.Visible = false;
            // 
            // ModifyPartCancel
            // 
            ModifyPartCancel.Location = new Point(223, 395);
            ModifyPartCancel.Name = "ModifyPartCancel";
            ModifyPartCancel.Size = new Size(51, 23);
            ModifyPartCancel.TabIndex = 50;
            ModifyPartCancel.Text = "Cancel";
            ModifyPartCancel.UseVisualStyleBackColor = true;
            ModifyPartCancel.Click += this.ModifyPartCancel_Click;
            // 
            // ModifyPartSave
            // 
            ModifyPartSave.Location = new Point(130, 395);
            ModifyPartSave.Name = "ModifyPartSave";
            ModifyPartSave.Size = new Size(51, 23);
            ModifyPartSave.TabIndex = 49;
            ModifyPartSave.Text = "Save";
            ModifyPartSave.UseVisualStyleBackColor = true;
            ModifyPartSave.Click += this.ModifyPartSave_Click;
            // 
            // ModifyPartMaxInput
            // 
            ModifyPartMaxInput.Location = new Point(177, 301);
            ModifyPartMaxInput.Name = "ModifyPartMaxInput";
            ModifyPartMaxInput.Size = new Size(140, 23);
            ModifyPartMaxInput.TabIndex = 48;
            // 
            // ModifyPartMinInput
            // 
            ModifyPartMinInput.Location = new Point(177, 260);
            ModifyPartMinInput.Name = "ModifyPartMinInput";
            ModifyPartMinInput.Size = new Size(140, 23);
            ModifyPartMinInput.TabIndex = 47;
            // 
            // ModifyPartNameInput
            // 
            ModifyPartNameInput.Location = new Point(177, 137);
            ModifyPartNameInput.Name = "ModifyPartNameInput";
            ModifyPartNameInput.Size = new Size(140, 23);
            ModifyPartNameInput.TabIndex = 46;
            // 
            // ModifyPartInventoryInput
            // 
            ModifyPartInventoryInput.Location = new Point(177, 178);
            ModifyPartInventoryInput.Name = "ModifyPartInventoryInput";
            ModifyPartInventoryInput.Size = new Size(140, 23);
            ModifyPartInventoryInput.TabIndex = 45;
            // 
            // ModifyPartMachineIdInput
            // 
            ModifyPartMachineIdInput.Location = new Point(177, 342);
            ModifyPartMachineIdInput.Name = "ModifyPartMachineIdInput";
            ModifyPartMachineIdInput.Size = new Size(140, 23);
            ModifyPartMachineIdInput.TabIndex = 44;
            // 
            // ModifyPartPriceInput
            // 
            ModifyPartPriceInput.Location = new Point(177, 219);
            ModifyPartPriceInput.Name = "ModifyPartPriceInput";
            ModifyPartPriceInput.Size = new Size(140, 23);
            ModifyPartPriceInput.TabIndex = 43;
            // 
            // ModifyPartInventoryLabel
            // 
            ModifyPartInventoryLabel.AutoSize = true;
            ModifyPartInventoryLabel.Location = new Point(87, 182);
            ModifyPartInventoryLabel.Name = "ModifyPartInventoryLabel";
            ModifyPartInventoryLabel.Size = new Size(62, 15);
            ModifyPartInventoryLabel.TabIndex = 42;
            ModifyPartInventoryLabel.Text = "Inventory";
            // 
            // ModifyPartPriceLabel
            // 
            ModifyPartPriceLabel.AutoSize = true;
            ModifyPartPriceLabel.Location = new Point(79, 223);
            ModifyPartPriceLabel.Name = "ModifyPartPriceLabel";
            ModifyPartPriceLabel.Size = new Size(70, 15);
            ModifyPartPriceLabel.TabIndex = 41;
            ModifyPartPriceLabel.Text = "Price / Cost";
            // 
            // ModifyPartMinLabel
            // 
            ModifyPartMinLabel.AutoSize = true;
            ModifyPartMinLabel.Location = new Point(121, 264);
            ModifyPartMinLabel.Name = "ModifyPartMinLabel";
            ModifyPartMinLabel.Size = new Size(28, 15);
            ModifyPartMinLabel.TabIndex = 40;
            ModifyPartMinLabel.Text = "Min";
            // 
            // ModifyPartMaxLabel
            // 
            ModifyPartMaxLabel.AutoSize = true;
            ModifyPartMaxLabel.Location = new Point(118, 305);
            ModifyPartMaxLabel.Name = "ModifyPartMaxLabel";
            ModifyPartMaxLabel.Size = new Size(31, 15);
            ModifyPartMaxLabel.TabIndex = 39;
            ModifyPartMaxLabel.Text = "Max";
            // 
            // ModifyPartNameLabel
            // 
            ModifyPartNameLabel.AutoSize = true;
            ModifyPartNameLabel.Location = new Point(109, 141);
            ModifyPartNameLabel.Name = "ModifyPartNameLabel";
            ModifyPartNameLabel.Size = new Size(40, 15);
            ModifyPartNameLabel.TabIndex = 37;
            ModifyPartNameLabel.Text = "Name";
            // 
            // ModifyPartIdInput
            // 
            ModifyPartIdInput.Enabled = false;
            ModifyPartIdInput.Location = new Point(177, 96);
            ModifyPartIdInput.Name = "ModifyPartIdInput";
            ModifyPartIdInput.Size = new Size(140, 23);
            ModifyPartIdInput.TabIndex = 36;
            // 
            // ModifyPartIdLabel
            // 
            ModifyPartIdLabel.AutoSize = true;
            ModifyPartIdLabel.Location = new Point(129, 100);
            ModifyPartIdLabel.Name = "ModifyPartIdLabel";
            ModifyPartIdLabel.Size = new Size(20, 15);
            ModifyPartIdLabel.TabIndex = 35;
            ModifyPartIdLabel.Text = "ID";
            // 
            // ModifyPartLabel
            // 
            ModifyPartLabel.AutoSize = true;
            ModifyPartLabel.BackColor = Color.Transparent;
            ModifyPartLabel.Font = new Font("Segoe UI", 15F);
            ModifyPartLabel.ForeColor = SystemColors.ControlText;
            ModifyPartLabel.Location = new Point(12, 9);
            ModifyPartLabel.Name = "ModifyPartLabel";
            ModifyPartLabel.Size = new Size(114, 28);
            ModifyPartLabel.TabIndex = 34;
            ModifyPartLabel.Text = "Modify Part";
            ModifyPartLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ModifyPartOutsourcedRadio
            // 
            ModifyPartOutsourcedRadio.AutoSize = true;
            ModifyPartOutsourcedRadio.Location = new Point(206, 55);
            ModifyPartOutsourcedRadio.Name = "ModifyPartOutsourcedRadio";
            ModifyPartOutsourcedRadio.Size = new Size(90, 19);
            ModifyPartOutsourcedRadio.TabIndex = 33;
            ModifyPartOutsourcedRadio.Text = "Outsourced";
            ModifyPartOutsourcedRadio.UseVisualStyleBackColor = true;
            ModifyPartOutsourcedRadio.CheckedChanged += this.ModifyPartOutsourcedRadio_CheckedChanged;
            // 
            // ModifyPartInHouseRadio
            // 
            ModifyPartInHouseRadio.AutoSize = true;
            ModifyPartInHouseRadio.Checked = true;
            ModifyPartInHouseRadio.Location = new Point(108, 55);
            ModifyPartInHouseRadio.Name = "ModifyPartInHouseRadio";
            ModifyPartInHouseRadio.Size = new Size(76, 19);
            ModifyPartInHouseRadio.TabIndex = 32;
            ModifyPartInHouseRadio.TabStop = true;
            ModifyPartInHouseRadio.Text = "In-House";
            ModifyPartInHouseRadio.UseVisualStyleBackColor = true;
            ModifyPartInHouseRadio.CheckedChanged += this.ModifyPartInHouseRadio_CheckedChanged;
            // 
            // ModifyPartMachineIdLabel
            // 
            ModifyPartMachineIdLabel.AutoSize = true;
            ModifyPartMachineIdLabel.Location = new Point(79, 346);
            ModifyPartMachineIdLabel.Name = "ModifyPartMachineIdLabel";
            ModifyPartMachineIdLabel.Size = new Size(70, 15);
            ModifyPartMachineIdLabel.TabIndex = 38;
            ModifyPartMachineIdLabel.Text = "Machine ID";
            // 
            // ModifyPartCompanyNameLabel
            // 
            ModifyPartCompanyNameLabel.AutoSize = true;
            ModifyPartCompanyNameLabel.Location = new Point(55, 346);
            ModifyPartCompanyNameLabel.Name = "ModifyPartCompanyNameLabel";
            ModifyPartCompanyNameLabel.Size = new Size(94, 15);
            ModifyPartCompanyNameLabel.TabIndex = 51;
            ModifyPartCompanyNameLabel.Text = "Company Name";
            ModifyPartCompanyNameLabel.Visible = false;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(ModifyPartCancel);
            Controls.Add(ModifyPartSave);
            Controls.Add(ModifyPartMaxInput);
            Controls.Add(ModifyPartMinInput);
            Controls.Add(ModifyPartNameInput);
            Controls.Add(ModifyPartInventoryInput);
            Controls.Add(ModifyPartPriceInput);
            Controls.Add(ModifyPartInventoryLabel);
            Controls.Add(ModifyPartPriceLabel);
            Controls.Add(ModifyPartMinLabel);
            Controls.Add(ModifyPartMaxLabel);
            Controls.Add(ModifyPartNameLabel);
            Controls.Add(ModifyPartIdInput);
            Controls.Add(ModifyPartIdLabel);
            Controls.Add(ModifyPartLabel);
            Controls.Add(ModifyPartOutsourcedRadio);
            Controls.Add(ModifyPartInHouseRadio);
            Controls.Add(ModifyPartMachineIdLabel);
            Controls.Add(ModifyPartCompanyNameLabel);
            Controls.Add(ModifyPartCompanyInput);
            Controls.Add(ModifyPartMachineIdInput);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "ModifyPartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Part";
            Load += ModifyPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ModifyPartCompanyInput;
        private Button ModifyPartCancel;
        private Button ModifyPartSave;
        private TextBox ModifyPartMaxInput;
        private TextBox ModifyPartMinInput;
        private TextBox ModifyPartNameInput;
        private TextBox ModifyPartInventoryInput;
        private TextBox ModifyPartMachineIdInput;
        private TextBox ModifyPartPriceInput;
        private Label ModifyPartInventoryLabel;
        private Label ModifyPartPriceLabel;
        private Label ModifyPartMinLabel;
        private Label ModifyPartMaxLabel;
        private Label ModifyPartNameLabel;
        private TextBox ModifyPartIdInput;
        private Label ModifyPartIdLabel;
        private Label ModifyPartLabel;
        private RadioButton ModifyPartOutsourcedRadio;
        private RadioButton ModifyPartInHouseRadio;
        private Label ModifyPartMachineIdLabel;
        private Label ModifyPartCompanyNameLabel;
    }
}