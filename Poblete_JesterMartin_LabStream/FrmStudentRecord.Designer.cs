namespace Sulit_Justin_LabStream
{
    partial class FrmStudentRecord
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
            lblViewRecord = new Label();
            lvShowText = new ListView();
            columnHeader1 = new ColumnHeader();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblViewRecord
            // 
            lblViewRecord.AutoSize = true;
            lblViewRecord.Font = new Font("Cascadia Code", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewRecord.ForeColor = Color.Black;
            lblViewRecord.Location = new Point(20, 15);
            lblViewRecord.Name = "lblViewRecord";
            lblViewRecord.Size = new Size(204, 39);
            lblViewRecord.TabIndex = 0;
            lblViewRecord.Text = "VIEW RECORD";
            // 
            // lvShowText
            // 
            lvShowText.BackColor = Color.White;
            lvShowText.BorderStyle = BorderStyle.FixedSingle;
            lvShowText.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvShowText.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvShowText.ForeColor = Color.FromArgb(22, 43, 82);
            lvShowText.FullRowSelect = true;
            lvShowText.HeaderStyle = ColumnHeaderStyle.None;
            lvShowText.Location = new Point(20, 65);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(440, 280);
            lvShowText.TabIndex = 1;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 420;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CadetBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(480, 65);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 40);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.CadetBlue;
            btnFind.Cursor = Cursors.Hand;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(480, 115);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(110, 40);
            btnFind.TabIndex = 4;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click_1;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.CadetBlue;
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(480, 165);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(110, 40);
            btnUpload.TabIndex = 5;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(604, 361);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Controls.Add(lblViewRecord);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblViewRecord;
        private ListView lvShowText;
        private ColumnHeader columnHeader1;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
        private OpenFileDialog openFileDialog1;
    }
}