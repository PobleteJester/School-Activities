namespace Poblete_ClubRegistration
{
    partial class FrmClubRegistration
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpRegistration = new GroupBox();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblGender = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblProgram = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            btnRegister = new Button();
            btnUpdate = new Button();
            grpList = new GroupBox();
            dataGridView = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            grpRegistration.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grpRegistration
            // 
            grpRegistration.BackColor = Color.WhiteSmoke;
            grpRegistration.Controls.Add(cmbGender);
            grpRegistration.Controls.Add(cmbProgram);
            grpRegistration.Controls.Add(lblGender);
            grpRegistration.Controls.Add(lblAge);
            grpRegistration.Controls.Add(txtAge);
            grpRegistration.Controls.Add(txtMiddleName);
            grpRegistration.Controls.Add(lblMiddleName);
            grpRegistration.Controls.Add(txtFirstName);
            grpRegistration.Controls.Add(lblFirstName);
            grpRegistration.Controls.Add(txtLastName);
            grpRegistration.Controls.Add(lblLastName);
            grpRegistration.Controls.Add(lblProgram);
            grpRegistration.Controls.Add(txtStudentId);
            grpRegistration.Controls.Add(lblStudentId);
            grpRegistration.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            grpRegistration.ForeColor = Color.Black;
            grpRegistration.Location = new Point(23, 67);
            grpRegistration.Name = "grpRegistration";
            grpRegistration.Size = new Size(590, 235);
            grpRegistration.TabIndex = 0;
            grpRegistration.TabStop = false;
            grpRegistration.Text = "Member Information";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(208, 185);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(170, 24);
            cmbGender.TabIndex = 14;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.White;
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.FlatStyle = FlatStyle.Flat;
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Hospitality Management", "BS in Business Administration" });
            cmbProgram.Location = new Point(318, 55);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(250, 24);
            cmbProgram.TabIndex = 13;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(205, 160);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(56, 16);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(15, 160);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(35, 16);
            lblAge.TabIndex = 11;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(18, 185);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 21);
            txtAge.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(398, 120);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(170, 21);
            txtMiddleName.TabIndex = 9;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.ForeColor = Color.Black;
            lblMiddleName.Location = new Point(395, 95);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(91, 16);
            lblMiddleName.TabIndex = 8;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(208, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 21);
            txtFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(205, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(84, 16);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(18, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 21);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(15, 95);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(77, 16);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(315, 30);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(63, 16);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program:";
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = Color.White;
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.ForeColor = Color.Black;
            txtStudentId.Location = new Point(18, 55);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(200, 21);
            txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(15, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(84, 16);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Green;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(632, 77);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 40);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(632, 127);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // grpList
            // 
            grpList.BackColor = Color.WhiteSmoke;
            grpList.Controls.Add(dataGridView);
            grpList.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            grpList.ForeColor = Color.Black;
            grpList.Location = new Point(22, 317);
            grpList.Name = "grpList";
            grpList.Size = new Size(750, 250);
            grpList.TabIndex = 3;
            grpList.TabStop = false;
            grpList.Text = "List Of Club Members";
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 180, 180);
            dataGridViewCellStyle1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(120, 120, 120);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.FromArgb(220, 220, 220);
            dataGridView.GridColor = Color.FromArgb(110, 110, 110);
            dataGridView.Location = new Point(6, 25);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(738, 219);
            dataGridView.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightBlue;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(632, 243);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 5;
            label1.Text = "Club Registration";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(750, 2);
            label2.TabIndex = 6;
            label2.Text = "Club Registration";
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 602);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(grpList);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(grpRegistration);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Registration";
            Load += FrmClubRegistration_Load;
            grpRegistration.ResumeLayout(false);
            grpRegistration.PerformLayout();
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpRegistration;
        private Label lblProgram;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblMiddleName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblGender;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtMiddleName;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Button btnRegister;
        private Button btnUpdate;
        private GroupBox grpList;
        private DataGridView dataGridView;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
    }
}
