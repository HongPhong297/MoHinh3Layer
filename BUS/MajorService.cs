//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BUS
//{
//    internal class MajorService
//    {
//    }
//}

using System.Data;
using DAL.Entities;


namespace BUS
{
    public class MajorService
    {
        private readonly MajorRepository majorRepository;

        public MajorService()
        {
            majorRepository = new MajorRepository();
        }

        // Lấy tất cả chuyên ngành
        public DataTable GetAllMajors()
        {
            return majorRepository.GetMajors();
        }

        // Lấy chuyên ngành theo ID
        public DataRow GetMajorByID(int majorID)
        {
            return majorRepository.GetMajorByID(majorID);
        }

        public DataTable GetMajorsByFaculty(int facultyID)
        {
            return majorRepository.GetMajorsByFaculty(facultyID);
        }
        // Thêm các logic nghiệp vụ (nếu cần)
    }
}

