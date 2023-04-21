using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Data
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

        public void AddStudent(Student student)
        {
            Class cl = db.Classes.Find(student.ClassID);
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

        public void EditStudent(Student student, string classIdOld)
        {
            Student selectedStudent = db.Students.Find(student.StudentID);
            Class classOld = db.Classes.Find(classIdOld);
            Class classNew = db.Classes.Find(student.ClassID);

            selectedStudent.StudentID = student.StudentID;
            selectedStudent.StudentName = student.StudentName;
            selectedStudent.DayOfBirth = student.DayOfBirth;
            selectedStudent.ID = student.ID;
            selectedStudent.Email = student.Email;
            selectedStudent.Phone = student.Phone;
            selectedStudent.StudentAddress = student.StudentAddress;

            if (classIdOld != string.Empty && classIdOld != student.ClassID)
            {
                classOld.TotalStudent -= 1;
                classNew.TotalStudent += 1;
                selectedStudent.ClassID = student.ClassID;
            }
            else
            {
                if (classIdOld == string.Empty)
                {
                    selectedStudent.ClassID = student.ClassID;
                    classNew.TotalStudent += 1;
                }
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
