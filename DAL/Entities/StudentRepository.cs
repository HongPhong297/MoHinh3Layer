using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Entities
{
    public class StudentRepository
    {
        private string connectionString = @"Server=DESKTOP-OO0TN7P\SQLEXPRESS;Database=StudentManagements;Trusted_Connection=True;";


        public DataTable GetStudents()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT s.StudentID AS MSSV, 
                           s.FullName AS [Họ Tên], 
                           f.FacultyName AS Khoa, 
                           s.AverageScore AS ĐTB, 
                           m.Name AS [Chuyên Ngành]
                    FROM Student s
                    LEFT JOIN Faculty f ON s.FacultyID = f.FacultyID
                    LEFT JOIN Major m ON s.MajorID = m.MajorID";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }


        //public void AddStudent(Student student)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = @"INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, MajorID, Avatar) 
        //                 VALUES (@StudentID, @FullName, @AverageScore, @FacultyID, @MajorID, @Avatar)";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@StudentID", student.StudentID);
        //        command.Parameters.AddWithValue("@FullName", student.FullName);
        //        command.Parameters.AddWithValue("@AverageScore", student.AverageScore);
        //        command.Parameters.AddWithValue("@FacultyID", student.FacultyID);

        //        // Chỉ thêm MajorID nếu không phải là null
        //        command.Parameters.AddWithValue("@MajorID", (object)student.MajorID ?? DBNull.Value);
        //        command.Parameters.AddWithValue("@Avatar", student.Avatar);

        //        connection.Open();
        //        try
        //        {
        //            command.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            // Xử lý hoặc ghi log lỗi
        //            throw new Exception("Không thể thêm sinh viên: " + ex.Message);
        //        }


        //    }
        //}
        public void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, Avatar) 
                         VALUES (@StudentID, @FullName, @AverageScore, @FacultyID, @Avatar)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", student.StudentID);
                command.Parameters.AddWithValue("@FullName", student.FullName);
                command.Parameters.AddWithValue("@AverageScore", student.AverageScore);
                command.Parameters.AddWithValue("@FacultyID", student.FacultyID);

                command.Parameters.AddWithValue("@Avatar", student.Avatar);

                

                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý hoặc ghi log lỗi
                    throw new Exception("Không thể thêm sinh viên: " + ex.Message);
                }
            }
        }

        // Phương thức sửa sinh viên
        public void UpdateStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Student SET FullName = @FullName, AverageScore = @AverageScore, 
                         FacultyID = @FacultyID, Avatar = @Avatar 
                         WHERE StudentID = @StudentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", student.StudentID);
                command.Parameters.AddWithValue("@FullName", student.FullName);
                command.Parameters.AddWithValue("@AverageScore", student.AverageScore);
                command.Parameters.AddWithValue("@FacultyID", student.FacultyID);

                // Chỉ thêm MajorID nếu không phải là null
                //command.Parameters.AddWithValue("@MajorID", (object)student.MajorID ?? DBNull.Value);
                command.Parameters.AddWithValue("@Avatar", student.Avatar);

                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý hoặc ghi log lỗi
                    throw new Exception("Không thể cập nhật sinh viên: " + ex.Message);
                }
            }
        }


        public DataTable GetStudentsWithNullMajor()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT s.StudentID AS MSSV, 
                   s.FullName AS [Họ Tên], 
                   f.FacultyName AS Khoa, 
                   s.AverageScore AS ĐTB, 
                   m.Name AS [Chuyên Ngành]
            FROM Student s
            LEFT JOIN Faculty f ON s.FacultyID = f.FacultyID
            LEFT JOIN Major m ON s.MajorID = m.MajorID
            WHERE s.MajorID IS NULL";  // Lọc sinh viên có MajorID là null

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public DataTable GetStudentsWithNullMajor(string FacultyName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Thêm điều kiện WHERE cho FacultyName
                string query = @"
            SELECT s.StudentID AS MSSV, 
                   s.FullName AS [Họ Tên], 
                   f.FacultyName AS Khoa, 
                   s.AverageScore AS ĐTB                 
            FROM Student s
            LEFT JOIN Faculty f ON s.FacultyID = f.FacultyID
            LEFT JOIN Major m ON s.MajorID = m.MajorID
            WHERE s.MajorID IS NULL
            AND f.FacultyName = @FacultyName";  // Lọc sinh viên theo tên khoa và MajorID là null

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Truyền tham số FacultyName vào câu truy vấn
                    command.Parameters.AddWithValue("@FacultyName", FacultyName);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }


        public void UpdateStudentMajor(int studentID, int majorID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Student 
                         SET MajorID = @MajorID 
                         WHERE StudentID = @StudentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentID);

                // If majorID is null, we pass DBNull.Value to the query.
                command.Parameters.AddWithValue("@MajorID", (object)majorID ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


    }
}
