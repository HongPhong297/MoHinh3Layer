
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Entities
{
    public class MajorRepository
    {
        private string connectionString = @"Server=DESKTOP-OO0TN7P\SQLEXPRESS;Database=StudentManagements;Trusted_Connection=True;";

        // Lấy tất cả chuyên ngành
        public DataTable GetMajors()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT Major.MajorID, Major.Name, Faculty.FacultyName 
                    FROM Major
                    LEFT JOIN Faculty ON Major.FacultyID = Faculty.FacultyID";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Lấy thông tin một chuyên ngành theo ID
        public DataRow GetMajorByID(int majorID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT Major.MajorID, Major.Name, Faculty.FacultyName 
                    FROM Major
                    LEFT JOIN Faculty ON Major.FacultyID = Faculty.FacultyID
                    WHERE Major.MajorID = @MajorID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MajorID", majorID);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0];
            return null;
        }


        public DataTable GetMajorsByFaculty(int facultyID)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MajorID, Name FROM Major WHERE FacultyID = @FacultyID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FacultyID", facultyID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

    }
}
