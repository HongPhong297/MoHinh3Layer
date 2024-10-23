
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Entities
{
    public class FacultyRepository
    {
        private string connectionString = @"Server=DESKTOP-OO0TN7P\SQLEXPRESS;Database=StudentManagements;Trusted_Connection=True;";

        // Lấy tất cả khoa
        public DataTable GetFaculties()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FacultyID, FacultyName FROM Faculty";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Lấy thông tin một khoa theo ID
        public DataRow GetFacultyByID(int facultyID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FacultyID, FacultyName FROM Faculty WHERE FacultyID = @FacultyID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacultyID", facultyID);
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


        public List<string> GetAllFacultyNames()
        {
            List<string> facultyNames = new List<string>();

            // Tạo câu lệnh SQL để lấy tên khoa
            string query = "SELECT FacultyName FROM Faculty";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc kết quả và thêm tên khoa vào danh sách
                    while (reader.Read())
                    {
                        facultyNames.Add(reader["FacultyName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ (nếu cần)
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return facultyNames;
        }

        public int GetFacultyIDByName(string facultyName)
        {
            // Khởi tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FacultyID FROM Faculty WHERE FacultyName = @FacultyName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacultyName", facultyName);

                    // Thực thi truy vấn và lấy kết quả
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int facultyID))
                    {
                        return facultyID; // Trả về FacultyID nếu tìm thấy
                    }
                }
            }

            return -1; // Trả về null nếu không tìm thấy
        }
    }
}
