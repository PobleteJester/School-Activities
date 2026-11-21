namespace Poblete_ClubRegistration
{
    partial class FrmUpdateMember
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
            lblStudentId = new Label();
            cmbStudentId = new ComboBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblProgram = new Label();
            btnConfirm = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(40, 73);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(96, 17);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // cmbStudentId
            // 
            cmbStudentId.BackColor = Color.White;
            cmbStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentId.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            cmbStudentId.ForeColor = Color.Black;
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(43, 98);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(280, 25);
            cmbStudentId.TabIndex = 2;
            cmbStudentId.SelectedIndexChanged += cmbStudentId_SelectedIndexChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(40, 143);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 17);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(43, 168);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 23);
            txtLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(40, 213);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 17);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(43, 238);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 23);
            txtFirstName.TabIndex = 6;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblMiddleName.ForeColor = Color.Black;
            lblMiddleName.Location = new Point(40, 286);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(104, 17);
            lblMiddleName.TabIndex = 7;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(43, 311);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(280, 23);
            txtMiddleName.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(346, 143);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 17);
            lblAge.TabIndex = 9;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(349, 168);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(120, 23);
            txtAge.TabIndex = 10;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(346, 213);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 17);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(349, 238);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(180, 25);
            cmbGender.TabIndex = 12;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.White;
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(349, 98);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(280, 25);
            cmbProgram.TabIndex = 13;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.BackColor = Color.Transparent;
            lblProgram.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(346, 73);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(72, 17);
            lblProgram.TabIndex = 14;
            lblProgram.Text = "Program:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Green;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.FromArgb(18, 22, 28);
            btnConfirm.Location = new Point(43, 357);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 40);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(610, 2);
            label2.TabIndex = 17;
            label2.Text = "Club Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 35);
            label1.TabIndex = 16;
            label1.Text = "Club Registration";
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(643, 428);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(lblProgram);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cmbStudentId);
            Controls.Add(lblStudentId);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Member";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private ComboBox cmbStudentId;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Label lblProgram;
        private Button btnConfirm;
        private Label label2;
        private Label label1;
    }
}