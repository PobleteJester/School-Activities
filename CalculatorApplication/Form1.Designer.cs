namespace CalculatorApplication
{
    partial class Form1
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
            label1 = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblDisplayTotal = new Label();
            btnCalculate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnCalculate);
            panel1.Controls.Add(cbOperator);
            panel1.Controls.Add(txtBoxInput2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDisplayTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxInput1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 211);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Cascadia Mono", 12F);
            txtBoxInput1.Location = new Point(207, 7);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(174, 26);
            txtBoxInput1.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(268, 36);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(50, 27);
            cbOperator.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(190, 21);
            label2.TabIndex = 0;
            label2.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Cascadia Mono", 12F);
            txtBoxInput2.Location = new Point(207, 67);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(174, 26);
            txtBoxInput2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(207, 132);
            label3.Name = "label3";
            label3.Size = new Size(174, 1);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label4.Location = new Point(129, 111);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 0;
            label4.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Cascadia Mono", 12F);
            lblDisplayTotal.Location = new Point(207, 111);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(28, 21);
            lblDisplayTotal.TabIndex = 0;
            lblDisplayTotal.Text = "--";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Green;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.FromArgb(224, 224, 224);
            btnCalculate.Location = new Point(231, 156);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 211);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbOperator;
        private TextBox txtBoxInput1;
        private Label label1;
        private TextBox txtBoxInput2;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnCalculate;
        private Label lblDisplayTotal;
    }
}
