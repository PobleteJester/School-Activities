using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sulit_Justin_LabStream
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFileName.Text))
                    throw new FormatException("File Name must not be empty and can only contain letters and spaces.");
                SetFileName = txtFileName.Text + ".txt";
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
