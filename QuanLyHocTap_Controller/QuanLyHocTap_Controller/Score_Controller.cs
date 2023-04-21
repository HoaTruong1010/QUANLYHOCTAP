using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Data;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Controller
{
    public class Score_Controller
    {
        Score_DAO score_DAO;

        public Score_Controller ()
        {
            score_DAO = new Score_DAO();
        }

        public void GetScores(DataGridView dataGrirdView, string selectedStudentId)
        {
            dataGrirdView.DataSource = score_DAO.LoadScores(selectedStudentId);
        }

        public void GetScores(DataGridView dataGrirdView, int teachingID)
        {
            dataGrirdView.DataSource = score_DAO.LoadScores(teachingID);
        }

        public int AddScore(Score score)
        {
            int isValidScore = CheckData.IsValidScore(score);
            if(isValidScore == 0)
            {
                try
                {
                    score_DAO.AddScore(score);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return isValidScore;
        }

        public int EditScore(Score score)
        {
            int isValidScore = CheckData.IsValidScore(score);
            if(isValidScore == 0)
            {
                if (score_DAO.FindScore(score.TeachingID, score.StudentID, score.Registration_Date).Count > 0)
                {
                    try
                    {
                        score_DAO.EditScore(score);
                    }
                    catch (Exception)
                    {
                        return -2;
                    }
                }
                else { return -2; }
            }
            return isValidScore;            
        }

        public bool DeleteScore(int teachingId, string studentId, DateTime registerDate)
        {
            if (score_DAO.FindScore(teachingId, studentId, registerDate).Count > 0)
            {
                try
                {
                    score_DAO.DeleteScore(teachingId, studentId, registerDate);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else { return false; }
        }

        public int SearchTeaching(DataGridView dataGridView, string kw, string studentID)
        {
            dataGridView.DataSource = score_DAO.SearchScore(kw, studentID);

            if (dataGridView.Rows.Count > 0)
                return 0;
            return 10;
        }

        public List<ScoreStatictis> setChartData(DateTime start, DateTime finish)
        {
            return score_DAO.Statictis(start, finish);
        }
    }
}
