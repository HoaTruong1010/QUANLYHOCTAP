using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanlyHocTap_Data.DAO
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
            var listTeacher = db.Teachers.Select(s => s).ToList();
            return listTeacher;
        }
    }
}
