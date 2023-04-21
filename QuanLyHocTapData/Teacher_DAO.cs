using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Data
{
    public class Teacher_DAO
    {
        QuanLyHocTapEntities db;

        public Teacher_DAO()
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

        public dynamic GetTeacher(string teacherId) 
        {
            return db.Teachers.Where(t => t.TeacherID == teacherId)
                .Select(t => new 
                {
                    t.TeacherID,
                    t.TeacherName
                }).ToDictionary( x => x.TeacherID, x => x.TeacherName);
        }

        public dynamic SearchTeacher(string kw)
        {
            return db.Teachers.Where(t => t.TeacherID.ToLower().Contains(kw.ToLower()) || t.TeacherName.ToLower().Contains(kw.ToLower()))
                .Select(s => new
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
        }

        public dynamic LoadCBBTeachers()
        {
            var listTeacher = db.Teachers.Select(s => new
            {
                s.TeacherID,
                s.TeacherName
            }).ToList();
            return listTeacher;
        }

        public void AddTeacher(string teacherId, string teacherName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string certificate)
        {
            Teacher teacher = new Teacher();
            teacher.TeacherID = teacherId;
            teacher.TeacherName = teacherName;
            teacher.DayOfBirth = dateOfBirth;
            teacher.ID = cccd;
            teacher.Email = email;
            teacher.Phone = phone;
            teacher.TeacherAddress = address;
            teacher.TeacherCertificate = certificate;

            db.Teachers.Add(teacher);
            db.SaveChanges();
        }

        public bool FindTeacher(string teacherId)
        {
            Teacher teacher = db.Teachers.Find(teacherId);
            if (teacher != null) 
                return true;
            else
                return false;
        }

        public void EditTeacher(string teacherId, string teacherName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string certificate)
        {
            Teacher teacher = db.Teachers.Find(teacherId);
            teacher.TeacherID = teacherId;
            teacher.TeacherName = teacherName;
            teacher.DayOfBirth = dateOfBirth;
            teacher.ID = cccd;
            teacher.Email = email;
            teacher.Phone = phone;
            teacher.TeacherAddress = address;
            teacher.TeacherCertificate = certificate;

            db.SaveChanges();
        }

        public void DeleteTeacher(string teacherId)
        {
            Teacher teacher = db.Teachers.Find(teacherId);
            List<Class> classes = db.Classes.Where(c => c.TeacherID == teacherId).Select(s => s).ToList();
            List<Teaching> teachings = db.Teachings.Where(c => c.TeacherID == teacherId).Select(s => s).ToList();

            foreach (Class c in classes)
            {
                c.TeacherID = null;
            }

            foreach (Teaching c in teachings)
            {
                List<Score> scores = db.Scores.Where(s => s.TeachingID == c.ID).Select(s => s).ToList();
                foreach(Score score in scores)
                    db.Scores.Remove(score);
                db.Teachings.Remove(c);
            }

            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }
    }
}
