using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClubRegistration
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString;

        public string _FirstName;
        public string _MiddleName;
        public string _LastName;
        public string _Gender;
        public string _Program;

        public int _Age;

        public ClubRegistrationQuery()
        {
            connectionString = "Server=ANNEX-PC00;Database=PobleteClubDB;User ID=poblete.416877;Password=123456;TrustServerCertificate=True;"; ;

            sqlConnect = new SqlConnection(connectionString);

            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";

            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            dataTable.Clear();

            sqlAdapter.Fill(dataTable);

            bindingSource.DataSource = dataTable;

            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, " +
                "@FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public bool GetMember(long StudentID)
        {
            sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentId = @StudentID", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;

            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                _FirstName = sqlReader.GetString(0);
                _MiddleName = sqlReader.GetString(1);
                _LastName = sqlReader.GetString(2);
                _Age = sqlReader.GetInt32(3);
                _Gender = sqlReader.GetString(4);
                _Program = sqlReader.GetString(5);
            }
            sqlReader.Close();
            sqlConnect.Close();

            return true;
        }

        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentID", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }
    }
}