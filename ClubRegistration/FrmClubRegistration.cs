using ClubRegistration;

namespace Poblete_ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void RefreshListOfClubMembers()
        {
            try
            {
                if (clubRegistrationQuery.DisplayList())
                {
                    dataGridView.DataSource = clubRegistrationQuery.bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to refresh the list.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                clubRegistrationQuery = new ClubRegistrationQuery();
                RefreshListOfClubMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The form failed to load properly.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int RegistrationID()
        {
            count++;
            return count;
        }

        private void ClearFields()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            cmbProgram.SelectedIndex = -1;
            txtStudentId.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentId.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txtStudentId.Text.Trim(), out StudentId) || StudentId <= 0)
                {
                    MessageBox.Show("Student ID must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentId.Focus();
                    return;
                }

                if (!int.TryParse(txtAge.Text.Trim(), out Age) || Age < 1 || Age > 120)
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

                ID = RegistrationID();
                FirstName = txtFirstName.Text.Trim();
                MiddleName = txtMiddleName.Text.Trim();
                LastName = txtLastName.Text.Trim();
                Gender = cmbGender.Text;
                Program = cmbProgram.Text;

                if (clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program))
                {
                    MessageBox.Show("Student registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    RefreshListOfClubMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while registering.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
                frmUpdateMember.ShowDialog();
                RefreshListOfClubMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the update form.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}