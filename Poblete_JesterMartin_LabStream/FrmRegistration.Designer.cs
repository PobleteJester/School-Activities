namespace Poblete_JesterMartin_LabStream
{
    partial class FrmRegistration
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
            lblTitle = new Label();
            lblStudentNo = new Label();
            txtStudentNo = new TextBox();
            lblProgram = new Label();
            cboProgram = new ComboBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblMI = new Label();
            txtMI = new TextBox();
            txtAge = new TextBox();
            lblAge = new Label();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            lblContact = new Label();
            txtContact = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            btnRecords = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cascadia Code", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 39);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "REGISTRATION";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblStudentNo.ForeColor = Color.Black;
            lblStudentNo.Location = new Point(30, 84);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(96, 17);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Cascadia Code", 9.75F);
            txtStudentNo.Location = new Point(140, 80);
            txtStudentNo.MaxLength = 11;
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(140, 23);
            txtStudentNo.TabIndex = 2;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(295, 84);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(64, 17);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cboProgram
            // 
            cboProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProgram.FlatStyle = FlatStyle.Flat;
            cboProgram.Font = new Font("Cascadia Code", 9.75F);
            cboProgram.FormattingEnabled = true;
            cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Business Administration", "BS Computer Engineering", "BS Criminology", "BS Tourism Management", "BS Hospitality Management" });
            cboProgram.Location = new Point(385, 80);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(250, 25);
            cboProgram.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(30, 140);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 17);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(295, 140);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 17);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Cascadia Code", 9.75F);
            txtLastName.Location = new Point(140, 137);
            txtLastName.MaxLength = 100;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Cascadia Code", 9.75F);
            txtFirstName.Location = new Point(385, 137);
            txtFirstName.MaxLength = 100;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 23);
            txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblMI.ForeColor = Color.Black;
            lblMI.Location = new Point(560, 140);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(40, 17);
            lblMI.TabIndex = 9;
            lblMI.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Cascadia Code", 9.75F);
            txtMI.Location = new Point(600, 137);
            txtMI.MaxLength = 2;
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(50, 23);
            txtMI.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Cascadia Code", 9.75F);
            txtAge.Location = new Point(87, 200);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(80, 23);
            txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(30, 203);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(32, 17);
            lblAge.TabIndex = 12;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(215, 203);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(56, 17);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(289, 199);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(120, 25);
            cboGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblBirthday.ForeColor = Color.Black;
            lblBirthday.Location = new Point(30, 265);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(72, 17);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.CalendarFont = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthday.Location = new Point(140, 262);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(220, 25);
            dtpBirthday.TabIndex = 16;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblContact.ForeColor = Color.Black;
            lblContact.Location = new Point(380, 265);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(96, 17);
            lblContact.TabIndex = 17;
            lblContact.Text = "Contact No.";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Cascadia Code", 9.75F);
            txtContact.Location = new Point(480, 262);
            txtContact.MaxLength = 11;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(170, 23);
            txtContact.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CadetBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(260, 345);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 40);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.FromArgb(31, 58, 95);
            label1.Location = new Point(11, 59);
            label1.Name = "label1";
            label1.Size = new Size(640, 1);
            label1.TabIndex = 21;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.CadetBlue;
            btnRecords.Cursor = Cursors.Hand;
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(562, 349);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(90, 35);
            btnRecords.TabIndex = 22;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.FromArgb(31, 58, 95);
            label2.Location = new Point(11, 320);
            label2.Name = "label2";
            label2.Size = new Size(640, 1);
            label2.TabIndex = 23;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(664, 411);
            Controls.Add(label2);
            Controls.Add(btnRecords);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(dtpBirthday);
            Controls.Add(lblBirthday);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(txtMI);
            Controls.Add(lblMI);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(cboProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentNo;
        private TextBox txtStudentNo;
        private Label lblProgram;
        private ComboBox cboProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMI;
        private TextBox txtMI;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnRegister;
        private Label label1;
        private Button btnRecords;
        private Label label2;
    }
}