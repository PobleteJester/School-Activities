using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sulit_Justin_LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!long.TryParse(txtStudentNo.Text, out long studentNumber))
                    throw new FormatException("Invalid Input. Student Number: Letters/Special characters are not allowed.");

                if (string.IsNullOrWhiteSpace(txtLastName.Text) || !txtLastName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Last Name: Numbers/Special characters are not allowed.");

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !txtFirstName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. First Name: Numbers/Special characters are not allowed.");

                if (!int.TryParse(txtAge.Text, out int age))
                    throw new FormatException("Invalid Input. Age: Letters/Special characters are not allowed.");

                if (cboGender.SelectedIndex == -1)
                    throw new FormatException("Gender cannot be empty.");

                if (cboProgram.SelectedIndex == -1)
                    throw new FormatException("Program cannot be empty.");

                if (dtpBirthday.Value.Date > DateTime.Today)
                    throw new FormatException("Invalid birthday. Past to present date only.");

                if (string.IsNullOrWhiteSpace(txtContact.Text) || !txtContact.Text.All(char.IsDigit))
                    throw new FormatException("Invalid contact number. Letters/Special characters are not allowed.");

                string folderPath = Application.StartupPath;

                string[] studentInfo =
                {
                    "Student No.: " + txtStudentNo.Text,
                    "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + " " + txtMI.Text + ".",
                    "Program: " + cboProgram.Text,
                    "Gender: " + cboGender.Text,
                    "Age: " + txtAge.Text,
                    "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                    "Contact No.: " + txtContact.Text
                };

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, txtStudentNo.Text + ".txt")))
                {
                    foreach (string infoLine in studentInfo)
                    {
                        outputFile.WriteLine(infoLine);
                    }
                }

                MessageBox.Show("Registration successful! Check " + folderPath);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}