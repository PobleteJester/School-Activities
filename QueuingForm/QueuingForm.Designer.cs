namespace QueuingForm
{
    partial class QueuingForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblQueue = new Label();
            label3 = new Label();
            label1 = new Label();
            btnCashier = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 161);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(lblQueue);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCashier);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(478, 155);
            panel2.TabIndex = 0;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.BackColor = Color.Transparent;
            lblQueue.Font = new Font("Cascadia Mono", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(187, 52);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(220, 49);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Mono", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(26, 116);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 2;
            label3.Text = "*Click to get a number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 34);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 2;
            label1.Text = " Position in Queue";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.White;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(47, 21);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(90, 90);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 161);
            Controls.Add(panel1);
            Name = "QueuingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueuingForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnCashier;
        private Label lblQueue;
        private Label label3;
    }
}
