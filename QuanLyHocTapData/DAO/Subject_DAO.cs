﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTapData.DAO
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

        public dynamic LoadCBBSubjects()
        {
            var listSubject = db.Subjects.Select(s => new
            {
                s.SubjectID,
                s.SubjectName
            }).ToList();
            return listSubject;
        }
        public void AddSubject(string subjectId, string subjectName, int credits)
        {
            Subject subject = new Subject();
            subject.SubjectID = subjectId;
            subject.SubjectName = subjectName;
            subject.Credits = credits;

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

        public void EditSubject(string subjectId, string subjectName, int credits)
        {
            Subject subject = db.Subjects.Find(subjectId);
            subject.SubjectID = subjectId;
            subject.SubjectName = subjectName;
            subject.Credits = credits;

            db.SaveChanges();
        }

        public void DeleteSubject(string subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            db.Subjects.Remove(subject);
            db.SaveChanges();
        }
    }
}