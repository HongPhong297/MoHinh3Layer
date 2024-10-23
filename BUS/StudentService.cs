using System.Data;
using DAL.Entities;

namespace BUS
{
    public class StudentService
    {
        private StudentRepository studentRepository;

        public StudentService()
        {
            studentRepository = new StudentRepository();
        }

        public DataTable LoadStudents()
        {
            return studentRepository.GetStudents();
        }

        // Phương thức thêm sinh viên
        public void AddStudent(string studentID, string fullName, float? averageScore, int facultyID, string avatar)
        {
            // Tạo đối tượng Student từ các tham số lẻ
            Student student = new Student
            {
                StudentID = studentID,
                FullName = fullName,
                AverageScore = averageScore,
                FacultyID = facultyID,
                //MajorID = majorID,
                Avatar = avatar
            };

            // Gọi phương thức thêm sinh viên từ StudentRepository
            studentRepository.AddStudent(student);
        }


        // Phương thức sửa sinh viên
        public void UpdateStudent(string studentID, string fullName, float? averageScore, int facultyID,  string avatar)
        {
            // Tạo đối tượng Student từ các tham số lẻ
            Student student = new Student
            {
                StudentID = studentID,
                FullName = fullName,
                AverageScore = averageScore,
                FacultyID = facultyID,
                //MajorID = majorID,
                Avatar = avatar
            };

            // Gọi phương thức sửa sinh viên từ StudentRepository
            studentRepository.UpdateStudent(student);
        }
        // tra ve bang voi sv chua dk chuyen ngành
        public DataTable GetStudentsWithNullMajor()
        {
            return studentRepository.GetStudentsWithNullMajor();
        }

        public DataTable GetStudentsWithNullMajor(string FacultyName)
        {
            return studentRepository.GetStudentsWithNullMajor(FacultyName);
        }


        public void UpdateStudentMajor(int studentID, int majorID)
        {
            studentRepository.UpdateStudentMajor(studentID, majorID);
        }



    }
}
