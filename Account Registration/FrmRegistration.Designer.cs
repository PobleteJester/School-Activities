namespace Account_Registration
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            txtStudentNo = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtMiddleName = new TextBox();
            label8 = new Label();
            txtContactNo = new TextBox();
            cbProgram = new ComboBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 43);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label2.Location = new Point(204, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 43);
            label2.TabIndex = 0;
            label2.Text = "Program:";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Cascadia Mono", 12F);
            txtStudentNo.Location = new Point(16, 34);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(182, 26);
            txtStudentNo.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(123, 43);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Cascadia Mono", 12F);
            txtLastName.Location = new Point(16, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(182, 26);
            txtLastName.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 121);
            label6.Name = "label6";
            label6.Size = new Size(123, 43);
            label6.TabIndex = 0;
            label6.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Cascadia Mono", 12F);
            txtAge.Location = new Point(16, 146);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(182, 26);
            txtAge.TabIndex = 1;
            // 
            // label7
            // 
            label7.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label7.Location = new Point(12, 177);
            label7.Name = "label7";
            label7.Size = new Size(123, 43);
            label7.TabIndex = 0;
            label7.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Cascadia Mono", 12F);
            txtAddress.Location = new Point(16, 202);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(566, 147);
            txtAddress.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label4.Location = new Point(204, 64);
            label4.Name = "label4";
            label4.Size = new Size(123, 43);
            label4.TabIndex = 0;
            label4.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Cascadia Mono", 12F);
            txtFirstName.Location = new Point(208, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(182, 26);
            txtFirstName.TabIndex = 1;
            // 
            // label5
            // 
            label5.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label5.Location = new Point(396, 64);
            label5.Name = "label5";
            label5.Size = new Size(123, 43);
            label5.TabIndex = 0;
            label5.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Cascadia Mono", 12F);
            txtMiddleName.Location = new Point(400, 89);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(182, 26);
            txtMiddleName.TabIndex = 1;
            // 
            // label8
            // 
            label8.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            label8.Location = new Point(204, 121);
            label8.Name = "label8";
            label8.Size = new Size(139, 43);
            label8.TabIndex = 0;
            label8.Text = "Contact No.:";
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Cascadia Mono", 12F);
            txtContactNo.Location = new Point(208, 146);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(182, 26);
            txtContactNo.TabIndex = 1;
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(208, 34);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(295, 29);
            cbProgram.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(249, 355);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 394);
            Controls.Add(btnNext);
            Controls.Add(cbProgram);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtContactNo);
            Controls.Add(txtStudentNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private Label label3;
        private TextBox txtLastName;
        private Label label6;
        private TextBox txtAge;
        private Label label7;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtMiddleName;
        private Label label8;
        private TextBox txtContactNo;
        private ComboBox cbProgram;
        private Button btnNext;
    }
}
