using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
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

        public bool AddScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            try
            {
                score_DAO.AddScore(teachingId, studentId, registerDate, midtermScore, midtermScoreDate, endPoint, endPointDate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            if (score_DAO.FindScore(teachingId,studentId,registerDate))
            {
                try
                {
                    score_DAO.EditScore(teachingId, studentId, registerDate, midtermScore, midtermScoreDate, endPoint, endPointDate);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                } 
            }
            else { return false; }
        }

        public bool DeleteScore(int teachingId, string studentId, DateTime registerDate)
        {
            if (score_DAO.FindScore(teachingId, studentId, registerDate))
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
    }
}
