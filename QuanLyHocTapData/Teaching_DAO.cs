﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Data
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

        public dynamic LoadCBBTeachersBySubjectID(string subjectID, DateTime today)
        {
            return db.Teachings.Where(t => t.SubjectID == subjectID && SqlFunctions.DateDiff("day", t.RegisterDate, today) < 45).Select(s => new
            {
                s.TeacherID,
                s.Teacher.TeacherName
            }).ToList();
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

        public dynamic SearchTeaching(string kw, string teacherID)
        {
            kw = kw.ToLower();
            return db.Teachings.Where(t => t.TeacherID == teacherID && t.Subject.SubjectName.ToLower().Contains(kw))
                .Select(s => new
                {
                    s.ID,
                    s.SubjectID,
                    s.Subject.SubjectName,
                    s.RegisterDate
                }).ToList();
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
                .Select(s => new { s.ID, s.RegisterDate }).ToDictionary(d => d.ID, d => d.RegisterDate);
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

        public void DeleteTeaching(int id)
        {
            Teaching teaching = db.Teachings.Find(id);

            List<Score> scores = db.Scores.Where(s => s.TeachingID == id).Select(s => s).ToList();
            foreach (Score score in scores)
                db.Scores.Remove(score);

            db.Teachings.Remove(teaching);
            db.SaveChanges();
        }
    }
}