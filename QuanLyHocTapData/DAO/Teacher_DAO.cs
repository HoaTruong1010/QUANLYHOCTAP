using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyHocTapData.DAO
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

        public dynamic LoadStudents()
        {
            var listStudent = db.Students.Select(s => new
            {
                s.StudentID,
                s.StudentName,
                s.DayOfBirth,
                s.ID,
                s.Email,
                s.Phone,
                s.StudentAddress,
                s.Class.ClassID, s.Class.ClassName
            }).ToList();
            return listStudent;
        }

        public dynamic LoadScores()
        {
            var listScore = db.Scores.Select(s => new
            {
                s.Teaching.Teacher.TeacherName, 
                s.Teaching.Subject.SubjectName,
                s.StudentID,
                s.Student.StudentName,
                s.Registration_Date,
                s.MidtermScore,
                s.ModifiedDateOfMidtermScore,
                s.EndPointScore,
                s.ModifiedDateOfEndPointScore
            }).ToList();
            return listScore;
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

        public dynamic LoadCBBStudents()
        {
            var listStudent = db.Students.Select(s => new
            {
                s.StudentID,
                s.StudentName
            }).ToList();
            return listStudent;
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
            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }
    }
}
