using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Sulit_Justin_LabStream
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
            this.FormClosed += FrmStudentRecord_FormClosed;
        }

        private void FrmStudentRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            lvShowText.Items.Clear();

            try
            {
                using (StreamReader streamReader = File.OpenText(openFileDialog1.FileName))
                {
                    string lineText;
                    while ((lineText = streamReader.ReadLine()) != null)
                    {
                        lvShowText.Items.Add(lineText);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot read the file.", "File Error");
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload");
            lvShowText.Items.Clear();
        }
    }
}