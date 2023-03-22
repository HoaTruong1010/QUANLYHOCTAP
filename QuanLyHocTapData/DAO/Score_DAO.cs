using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocTapData.DAO
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

        public bool FindScore(int teachingId, string studentId, DateTime registerDate)
        {
            Score score = db.Scores.Find(teachingId, studentId, registerDate);
            if (score != null)
                return true;
            else
                return false;
        }

        public void EditScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            Score score = db.Scores.Find(teachingId, studentId, registerDate);
            score.TeachingID = teachingId;
            score.StudentID = studentId;
            score.Registration_Date = registerDate;
            score.MidtermScore = midtermScore;
            score.ModifiedDateOfMidtermScore = midtermScoreDate;
            score.EndPointScore = endPoint;
            score.ModifiedDateOfEndPointScore= endPointDate;

            db.SaveChanges();
        }

        public void DeleteScore(int teachingId, string studentId, DateTime registerDate)
        {
            Score score = db.Scores.Find(teachingId, studentId, registerDate);
            db.Scores.Remove(score);
            db.SaveChanges();
        }
    }
}
