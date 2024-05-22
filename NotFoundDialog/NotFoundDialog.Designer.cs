namespace C968_Ogden
{
    partial class NotFoundDialog
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
            NotFoundLabel = new Label();
            NotFoundOk = new Button();
            SuspendLayout();
            // 
            // NotFoundLabel
            // 
            NotFoundLabel.AutoSize = true;
            NotFoundLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NotFoundLabel.Location = new Point(81, 19);
            NotFoundLabel.Name = "NotFoundLabel";
            NotFoundLabel.Size = new Size(91, 15);
            NotFoundLabel.TabIndex = 1;
            NotFoundLabel.Text = "Part Not Found";
            // 
            // NotFoundOk
            // 
            NotFoundOk.Location = new Point(89, 58);
            NotFoundOk.Name = "NotFoundOk";
            NotFoundOk.Size = new Size(75, 23);
            NotFoundOk.TabIndex = 2;
            NotFoundOk.Text = "OK";
            NotFoundOk.UseVisualStyleBackColor = true;
            NotFoundOk.Click += NotFoundOk_Click;
            // 
            // NotFoundDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(252, 101);
            ControlBox = false;
            Controls.Add(NotFoundOk);
            Controls.Add(NotFoundLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NotFoundDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NotFoundLabel;
        private Button NotFoundOk;
    }
}