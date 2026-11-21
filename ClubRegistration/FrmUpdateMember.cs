using ClubRegistration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Poblete_ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            try
            {
                clubRegistrationQuery = new ClubRegistrationQuery();

                cmbGender.Items.AddRange(new object[] { "Male", "Female" });
                cmbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Hospitality Management", "BS in Business Administration" });

                if (clubRegistrationQuery.DisplayList())
                {
                    foreach (DataRow memberRow in clubRegistrationQuery.dataTable.Rows)
                    {
                        cmbStudentId.Items.Add(memberRow["StudentId"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The update form failed to load properly.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!long.TryParse(cmbStudentId.Text, out long studentId))
                {
                    MessageBox.Show("The selected Student ID is not valid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clubRegistrationQuery.GetMember(studentId))
                {
                    txtLastName.Text = clubRegistrationQuery._LastName;
                    txtFirstName.Text = clubRegistrationQuery._FirstName;
                    txtMiddleName.Text = clubRegistrationQuery._MiddleName;
                    txtAge.Text = clubRegistrationQuery._Age.ToString();
                    cmbGender.SelectedItem = clubRegistrationQuery._Gender;
                    cmbProgram.SelectedItem = clubRegistrationQuery._Program;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading the member.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudentId.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Student ID first.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(cmbStudentId.Text, out long studentId))
                {
                    MessageBox.Show("The selected Student ID is not valid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("First name, last name, and age are required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 1 || age > 120)
                {
                    MessageBox.Show("Age must be a valid number from 1 to 120.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAge.Focus();
                    return;
                }

                if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a gender.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProgram.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a program.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clubRegistrationQuery.UpdateStudent(studentId, txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(), txtLastName.Text.Trim(), age, cmbGender.Text, cmbProgram.Text))
                {
                    MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}