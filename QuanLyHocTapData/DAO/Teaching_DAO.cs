using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTapData.DAO
{
    public class Teaching_DAO
    {
        QuanLyHocTapEntities db;

        public Teaching_DAO()
        {
            db = new QuanLyHocTapEntities();
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

        public void AddTeaching(string teacherID,
            string subjectID, DateTime registerDate)
        {
            Teaching teaching = new Teaching();
            teaching.TeacherID = teacherID;
            teaching.SubjectID = subjectID;
            teaching.RegisterDate = registerDate;

            db.Teachings.Add(teaching);
            db.SaveChanges();
        }

        public bool FindTeaching(int id)
        {
            Teaching teaching = db.Teachings.Find(id);
            if (teaching != null)
                return true;
            else
                return false;
        }

        public dynamic FindTeaching(string subjectId, string teacherId)
        {
            return db.Teachings.Where(t => t.SubjectID == subjectId && t.TeacherID == teacherId)
                .Select(s => new { s.ID, s.Teacher.TeacherName }).ToDictionary(d => d.ID, d => d.TeacherName);
        }

        public dynamic FindTeacherByTeachingId(int id)
        {
            return db.Teachings.Where(t => t.ID == id).Select(
                s => new
                {
                    s.TeacherID,
                    s.Teacher.TeacherName
                }).ToDictionary(d => d.TeacherID, d => d.TeacherName);
        }

        public dynamic FindSubjectByTeachingId(int id)
        {
            return db.Teachings.Where(t => t.ID == id).Select(
                s => new
                {
                    s.SubjectID,
                    s.Subject.SubjectName
                }).ToDictionary(d => d.SubjectID, d => d.SubjectName);
        }

        public void EditTeaching(int id, string teacherID,
            string subjectID, DateTime registerDate)
        {
            Teaching teaching = db.Teachings.Find(id);
            teaching.ID = id;
            teaching.TeacherID = teacherID;
            teaching.SubjectID = subjectID;
            teaching.RegisterDate = registerDate;

            db.SaveChanges();
        }

        public void DeleteTeaching(int id)
        {
            Teaching teaching = db.Teachings.Find(id);
            db.Teachings.Remove(teaching);
            db.SaveChanges();
        }
    }
}
