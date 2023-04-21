using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Data
{
    public class Subject_DAO
    {
        QuanLyHocTapEntities db;

        public Subject_DAO() 
        {
            db = new QuanLyHocTapEntities();
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

        public dynamic SearchSubject(string kw)
        {
            var listSubject = db.Subjects.Where(s=>s.SubjectID.ToLower().Contains(kw.ToLower()) || s.SubjectName.ToLower().Contains(kw.ToLower()))
                .Select(s => new
            {
                s.SubjectID,
                s.SubjectName,
                s.Credits
            }).ToList();
            return listSubject;
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

        public dynamic LoadCBBSubjects(string teacherSelectedID)
        {
            teacherSelectedID = teacherSelectedID.Substring(2, 2);
            var listSubject = db.Subjects.Where(s => s.SubjectID.StartsWith(teacherSelectedID)).Select(s => new
            {
                s.SubjectID,
                s.SubjectName
            }).ToList();
            return listSubject;
        }
        public void AddSubject(Subject subject)
        {
            db.Subjects.Add(subject);
            db.SaveChanges();
        }

        public bool FindSubject(string subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            if (subject != null)
                return true;
            else
                return false;
        }

        public bool FindSubjectName(string subjectName)
        {
            var subject = db.Subjects.Where(s => s.SubjectName.ToLower() == subjectName.ToLower()).Select(s => s.SubjectName).ToList();
            if (subject.Count > 0)
                return true;
            else
                return false;
        }

        public bool FindSubjectName(string subjectID, string subjectName)
        {
            var subject = db.Subjects.Where(s => s.SubjectName.ToLower() == subjectName.ToLower()).Select(s => s.SubjectID).ToList();
            if (subject.Count > 0)
            {
                foreach (var s in subject)
                    if (s.ToString() == subjectID)
                        return false;
                return true;
            }
            else
                return false;
        }

        public void EditSubject(Subject subject)
        {
            Subject selectedSubject = db.Subjects.Find(subject.SubjectID);
            selectedSubject.SubjectID = subject.SubjectID;
            selectedSubject.SubjectName = subject.SubjectName;
            selectedSubject.Credits = subject.Credits;

            db.SaveChanges();
        }

        public void DeleteSubject(string subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            List<Teaching> teachings = db.Teachings.Where(t => t.SubjectID == subjectId).Select(s => s).ToList();

            foreach (Teaching c in teachings)
            {
                List<Score> scores = db.Scores.Where(s => s.TeachingID == c.ID).Select(s => s).ToList();
                foreach (Score score in scores)
                    db.Scores.Remove(score);
                db.Teachings.Remove(c);
            }

            db.Subjects.Remove(subject);
            db.SaveChanges();
        }
    }
}
