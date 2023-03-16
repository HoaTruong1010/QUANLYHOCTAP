using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyHocTapData.DAO
{
    public class DAO_Teacher
    {
        QuanLyHocTapEntities db;

        public DAO_Teacher()
        {
            db = new QuanLyHocTapEntities();

        }

        public dynamic LoadTeachers()
        {
            var listTeacher = db.Teachers.Select(s => new
            {
                s.TeacherID,
                s.TeacherName,
                s.DayOfBirth,
                s.ID,
                s.Email,
                s.Phone,
                s.TeacherAddress,
                s.TeacherCertificate
            }).ToList();
            return listTeacher;
        }
    }
}
