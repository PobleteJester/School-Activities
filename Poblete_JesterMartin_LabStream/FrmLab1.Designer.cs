namespace Sulit_Justin_LabStream
{
    partial class FrmLab1
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
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.White;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 11F);
            txtInput.ForeColor = Color.FromArgb(31, 58, 95);
            txtInput.Location = new Point(27, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 90);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.CadetBlue;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(113, 158);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 45);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(364, 215);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLab1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
    }
}
