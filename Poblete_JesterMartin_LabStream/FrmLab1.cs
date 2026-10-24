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
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtInput.Text))
                    throw new FormatException("Input cannot be empty.");

                FrmFileName frmName = new FrmFileName();
                frmName.ShowDialog();

                string getInput = txtInput.Text;
                string docPath = Application.StartupPath;

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
