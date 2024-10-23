using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Student
    {
        public string StudentID { get; set; } // MSSV
        public string FullName { get; set; } // Họ Tên
        public float? AverageScore { get; set; } // Điểm Trung Bình
        public int FacultyID { get; set; } // Mã Khoa
        public int? MajorID { get; set; } // Mã Chuyên Ngành
        public string Avatar { get; set; } // Đường dẫn đến ảnh
    }
}
