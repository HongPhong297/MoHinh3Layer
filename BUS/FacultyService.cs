//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BUS
//{
//    internal class FacultyService
//    {
//    }
//}

using System.Collections.Generic;
using System.Data;
using DAL.Entities;


namespace BUS
{
    public class FacultyService
    {
        private readonly FacultyRepository facultyRepository;
        private readonly MajorRepository majorRepository;

        public FacultyService()
        {
            facultyRepository = new FacultyRepository();
        }

        // Lấy tất cả khoa
        public DataTable GetAllFaculties()
        {
            return facultyRepository.GetFaculties();
        }

        // Lấy khoa theo ID
        public DataRow GetFacultyByID(int facultyID)
        {
            return facultyRepository.GetFacultyByID(facultyID);
        }


        /// <summary>
        /// Lấy danh sách tên các khoa.
        /// </summary>
        /// <returns>Danh sách tên khoa.</returns>
        public List<string> GetAllFacultyNames()
        {
            return facultyRepository.GetAllFacultyNames();
        }
        // Thêm các logic nghiệp vụ (nếu có)
        // Ví dụ: Thêm chức năng validate dữ liệu trước khi thêm mới, sửa hoặc xóa

        public int GetFacultyIDByName(string facultyName)
        {
            return facultyRepository.GetFacultyIDByName(facultyName);
        }


        public DataTable GetMajorsByFaculty(int facultyID)
        {
            return majorRepository.GetMajorsByFaculty(facultyID);
        }

    }
}

