using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyHocTapData.DAO
{
    public class DAO_Load
    {
        QuanLyHocTapEntities db;

        public DAO_Load()
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
                }).ToList();
        }


        public dynamic LoadSubjects()
        {
            var listSubject = db.Subjects.Select(s => new
            {
                s.SubjectID,
                s.SubjectName,
                s.Credits
            }).ToList();
            return listSubject;
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

        public dynamic LoadTeachings(string id)
        {
            var listTeaching = db.Teachings.Where(t => t.TeacherID == id)
                .Select(s => new
            {
                s.ID,
                s.SubjectID,
                s.Subject.SubjectName,
                s.RegisterDate
            }).ToList();
            return listTeaching;
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

        public dynamic LoadCBBSubjects()
        {
            var listSubject = db.Subjects.Select(s => new
            {
                s.SubjectID,
                s.SubjectName
            }).ToList();
            return listSubject;
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
    }
}
