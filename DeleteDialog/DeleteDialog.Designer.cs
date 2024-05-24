namespace C968_Ogden
{
    partial class DeleteDialog
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
            DeleteDialogLabel = new Label();
            DialogCancel = new Button();
            DialogDelete = new Button();
            SuspendLayout();
            // 
            // DeleteDialogLabel
            // 
            DeleteDialogLabel.AutoSize = true;
            DeleteDialogLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeleteDialogLabel.Location = new Point(102, 22);
            DeleteDialogLabel.Name = "DeleteDialogLabel";
            DeleteDialogLabel.Size = new Size(50, 15);
            DeleteDialogLabel.TabIndex = 0;
            DeleteDialogLabel.Text = "Delete?";
            // 
            // DialogCancel
            // 
            DialogCancel.Location = new Point(134, 55);
            DialogCancel.Name = "DialogCancel";
            DialogCancel.Size = new Size(75, 23);
            DialogCancel.TabIndex = 1;
            DialogCancel.Text = "Cancel";
            DialogCancel.UseVisualStyleBackColor = true;
            DialogCancel.Click += DialogCancel_Click;
            // 
            // DialogDelete
            // 
            DialogDelete.Location = new Point(43, 55);
            DialogDelete.Name = "DialogDelete";
            DialogDelete.Size = new Size(75, 23);
            DialogDelete.TabIndex = 2;
            DialogDelete.Text = "Delete";
            DialogDelete.UseVisualStyleBackColor = true;
            DialogDelete.Click += DialogDelete_Click;
            
            // 
            // DeleteDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(252, 101);
            ControlBox = false;
            Controls.Add(DeleteDialogLabel);
            Controls.Add(DialogDelete);
            Controls.Add(DialogCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DeleteDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += DeleteDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeleteDialogLabel;
        private Button DialogCancel;
        private Button DialogDelete;
    }
}