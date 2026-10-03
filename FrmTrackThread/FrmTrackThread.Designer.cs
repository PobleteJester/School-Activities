namespace FrmTrackThread
{
    partial class FrmTrackThread
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
            lblShowStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblShowStatus
            // 
            lblShowStatus.AutoSize = true;
            lblShowStatus.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowStatus.Location = new Point(22, 40);
            lblShowStatus.Name = "lblShowStatus";
            lblShowStatus.Size = new Size(287, 35);
            lblShowStatus.TabIndex = 0;
            lblShowStatus.Text = "- THREAD STARTS -";
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(0, 192, 0);
            btnRun.FlatAppearance.BorderColor = Color.LightGray;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRun.ForeColor = Color.White;
            btnRun.Location = new Point(95, 98);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(130, 35);
            btnRun.TabIndex = 1;
            btnRun.Text = "RUN";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // FrmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 157);
            Controls.Add(btnRun);
            Controls.Add(lblShowStatus);
            Name = "FrmTrackThread";
            Text = "FrmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowStatus;
        private Button btnRun;
    }
}
