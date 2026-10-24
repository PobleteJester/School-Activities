namespace Sulit_Justin_LabStream
{
    partial class FrmFileName
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
            lblFileName = new Label();
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.Black;
            lblFileName.Location = new Point(25, 25);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(188, 25);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "Enter File Name:";
            // 
            // txtFileName
            // 
            txtFileName.BackColor = Color.White;
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Segoe UI", 11F);
            txtFileName.Location = new Point(25, 70);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(275, 27);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.CadetBlue;
            btnOkay.Cursor = Cursors.Hand;
            btnOkay.FlatAppearance.BorderSize = 0;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(101, 131);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(120, 38);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(324, 181);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFileName";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileName;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}