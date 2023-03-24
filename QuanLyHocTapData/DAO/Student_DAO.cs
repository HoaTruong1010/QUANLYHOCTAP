using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTapData.DAO
{
    public class Student_DAO
    {
        QuanLyHocTapEntities db;
        public Student_DAO() 
        { 
            db = new QuanLyHocTapEntities();
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
                s.Class.ClassID,
                s.Class.ClassName
            }).ToList();
            return listStudent;
        }

        public dynamic GetStudent(string studentId)
        {
            return db.Students.Where(t => t.StudentID == studentId)
                .Select(t => new
                {
                    t.StudentID,
                    t.StudentName
                }).ToDictionary(x => x.StudentID, x => x.StudentName);
        }

        public dynamic SearchStudent(string kw)
        {
            return db.Students.Where(t => t.StudentID.ToLower().Contains(kw.ToLower()) || t.StudentName.ToLower().Contains(kw.ToLower()))
                .Select(s => new
                {
                    s.StudentID,
                    s.StudentName,
                    s.DayOfBirth,
                    s.ID,
                    s.Email,
                    s.Phone,
                    s.StudentAddress,
                    s.Class.ClassID,
                    s.Class.ClassName
                }).ToList();
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

        public void AddStudent(string studentId, string studentName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string classId)
        {
            Student student = new Student();
            Class cl = db.Classes.Find(classId);
            student.StudentID = studentId;
            student.StudentName = studentName;
            student.DayOfBirth = dateOfBirth;
            student.ID = cccd;
            student.Email = email;
            student.Phone = phone;
            student.StudentAddress = address;
            student.ClassID = classId;
            cl.TotalStudent += 1;

            db.Students.Add(student);
            db.SaveChanges();
        }

        public bool FindStudent(string studentId)
        {
            Student student = db.Students.Find(studentId);
            if (student != null)
                return true;
            else
                return false;
        }

        public void EditStudent(string studentId, string studentName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string classIdNew, string classIdOld)
        {
            Student student = db.Students.Find(studentId);
            Class classOld = db.Classes.Find(classIdOld);
            Class classNew = db.Classes.Find(classIdNew);

            student.StudentID = studentId;
            student.StudentName = studentName;
            student.DayOfBirth = dateOfBirth;
            student.ID = cccd;
            student.Email = email;
            student.Phone = phone;
            student.StudentAddress = address;

            if (classIdOld != string.Empty && classIdOld != classIdNew)
            {
                classOld.TotalStudent -= 1;
                classNew.TotalStudent += 1;
                student.ClassID = classIdNew;
            }

            db.SaveChanges();
        }

        public void DeleteStudent(string studentId, string classID)
        {
            Student student = db.Students.Find(studentId);

            if(classID != string.Empty)
            {
                Class cl = db.Classes.Find(classID);
                int totalStudent = cl.TotalStudent;

                cl.TotalStudent = totalStudent - 1;
                db.SaveChanges();
            }
            List<Score> scores = db.Scores.Where(s => s.StudentID == studentId).Select(s => s).ToList();

            foreach (Score score in scores)
            {
                db.Scores.Remove(score);
            }

            db.Students.Remove(student);
            db.SaveChanges();

        }
    }
}
