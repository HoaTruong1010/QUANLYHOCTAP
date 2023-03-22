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
            student.StudentID = studentId;
            student.StudentName = studentName;
            student.DayOfBirth = dateOfBirth;
            student.ID = cccd;
            student.Email = email;
            student.Phone = phone;
            student.StudentAddress = address;
            student.ClassID = classId;

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
            string address, string classId)
        {
            Student student = db.Students.Find(studentId);
            student.StudentID = studentId;
            student.StudentName = studentName;
            student.DayOfBirth = dateOfBirth;
            student.ID = cccd;
            student.Email = email;
            student.Phone = phone;
            student.StudentAddress = address;
            student.ClassID = classId;

            db.SaveChanges();
        }

        public void DeleteStudent(string studentId)
        {
            Student student = db.Students.Find(studentId);
            db.Students.Remove(student);
            db.SaveChanges();
        }
    }
}
