using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTapData.DAO
{
    public class Class_DAO
    {
        QuanLyHocTapEntities db;

        public Class_DAO()
        {
            db = new QuanLyHocTapEntities();
        }

        public dynamic LoadClasses()
        {
            var listClass = db.Classes.Select(s => new
            {
                s.ClassID,
                s.ClassName,
                s.TotalStudent,
                s.TeacherID,
                s.Teacher.TeacherName
            }).ToList();
            return listClass;
        }

        public dynamic LoadCBBClasses()
        {
            var listClass = db.Classes.Select(s => new
            {
                s.ClassID,
                s.ClassName
            }).ToList();
            return listClass;
        }
        public void AddClass(string classId, string className,
            int total, string teacherId)
        {
            Class cl = new Class();
            cl.ClassID = classId;
            cl.ClassName = className;
            cl.TotalStudent = total;
            cl.TeacherID = teacherId;

            db.Classes.Add(cl);
            db.SaveChanges();
        }

        public bool FindCLass(string classId)
        {
            Class cl = db.Classes.Find(classId);
            if (cl != null)
                return true;
            else
                return false;
        }

        public void EditClass(string classId, string className,
            int total, string teacherId)
        {
            Class cl = db.Classes.Find(classId);
            cl.ClassID = classId;
            cl.ClassName = className;
            cl.TotalStudent = total;
            cl.TeacherID = teacherId;

            db.SaveChanges();
        }

        public void DeleteClass(string classId)
        {
            Class cl = db.Classes.Find(classId);
            db.Classes.Remove(cl);
            db.SaveChanges();
        }
    }
}
