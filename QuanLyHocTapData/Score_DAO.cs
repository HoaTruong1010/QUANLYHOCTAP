using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Data
{
    public class Score_DAO
    {
        QuanLyHocTapEntities db;

        public Score_DAO() 
        {
            db = new QuanLyHocTapEntities();
        }

        public dynamic LoadScores(string studentId)
        {
            var listScore = db.Scores.Where(s => s.StudentID == studentId)
                .Select(s => new
            {
                s.TeachingID,
                s.Teaching.Subject.SubjectName,
                s.Registration_Date,
                s.MidtermScore,
                s.ModifiedDateOfMidtermScore,
                s.EndPointScore,
                s.ModifiedDateOfEndPointScore
            }).ToList();
            return listScore;
        }

        public dynamic LoadScores(int teachingID)
        {
            var listScore = db.Scores.Where(s => s.TeachingID == teachingID)
                .Select(s => new
                {
                    s.StudentID,
                    s.Student.StudentName,
                    s.Student.Email,
                    s.Registration_Date,
                    s.MidtermScore,
                    s.ModifiedDateOfMidtermScore,
                    s.EndPointScore,
                    s.ModifiedDateOfEndPointScore
                }).ToList();
            return listScore;
        }

        public void AddScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            Score score = new Score();
            score.TeachingID = teachingId;
            score.StudentID = studentId;
            score.Registration_Date = registerDate;
            score.MidtermScore = midtermScore;
            score.ModifiedDateOfMidtermScore = midtermScoreDate;
            score.EndPointScore = endPoint;
            score.ModifiedDateOfEndPointScore = endPointDate;

            db.Scores.Add(score);
            db.SaveChanges();
        }

        public List<Score> FindScore(int teachingId, string studentId, DateTime registerDate)
        {
            List<Score> scores = db.Scores.Where(s => s.TeachingID == teachingId && s.StudentID == studentId && 
                                        SqlFunctions.DateDiff("day", s.Registration_Date, registerDate) == 0).Select(s=>s).ToList();
            return scores;
        }

        public void EditScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            List<Score> scores = FindScore(teachingId, studentId, registerDate);
            //Score score = db.Scores.Find(teachingId, studentId, registerDate);
            foreach(Score score in scores)
            {
                score.TeachingID = teachingId;
                score.StudentID = studentId;
                score.Registration_Date = registerDate;
                score.MidtermScore = midtermScore;
                score.ModifiedDateOfMidtermScore = midtermScoreDate;
                score.EndPointScore = endPoint;
                score.ModifiedDateOfEndPointScore = endPointDate;
            }

            db.SaveChanges();
        }

        public void DeleteScore(int teachingId, string studentId, DateTime registerDate)
        {
            Score score = db.Scores.Find(teachingId, studentId, registerDate);
            db.Scores.Remove(score);
            db.SaveChanges();
        }

        public dynamic SearchScore(string kw, string studentID)
        {
            kw = kw.ToLower();
            return db.Scores.Where(s => s.Teaching.Subject.SubjectName.ToLower().Contains(kw) && s.StudentID == studentID).Select(s => new
            {
                s.TeachingID,
                s.Teaching.Subject.SubjectName,
                s.Registration_Date,
                s.MidtermScore,
                s.ModifiedDateOfMidtermScore,
                s.EndPointScore,
                s.ModifiedDateOfEndPointScore
            }).ToList();
        }

        public List<ScoreStatictis> Statictis(DateTime start, DateTime finish)
        {
            ScoreStatictis scoreStatictis;
            List<ScoreStatictis> listScoreStatictis = new List<ScoreStatictis>();
            var collection = db.FN_SCORE_STATISTICS_OVERTIME(start, finish).ToList();
            foreach (var c in collection)
            {
                scoreStatictis = new ScoreStatictis();
                scoreStatictis.SOLUONG = c.SOLUONG;
                scoreStatictis.DIEM = c.DIEM;
                listScoreStatictis.Add(scoreStatictis);
            }
            return listScoreStatictis;
        }
    }
}
