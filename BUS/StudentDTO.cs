using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class StudentDTO
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public float? AverageScore { get; set; }
        public string FacultyID { get; set; }
        public string MajorID { get; set; }
        public string Avatar { get; set; }
    }
}
