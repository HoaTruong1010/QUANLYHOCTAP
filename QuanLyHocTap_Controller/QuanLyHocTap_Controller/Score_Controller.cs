﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
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

        public int AddScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            if (midtermScore > 10 || endPoint > 10)
                return 33;
            if (endPoint < 0 || midtermScore < 0)
                return 34;

            try
            {
                score_DAO.AddScore(teachingId, studentId, registerDate, midtermScore, midtermScoreDate, endPoint, endPointDate);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int EditScore(int teachingId, string studentId, DateTime registerDate, Decimal midtermScore,
            DateTime midtermScoreDate, Decimal endPoint, DateTime endPointDate)
        {
            if (midtermScore > 10 || endPoint > 10)
                return 33;
            if (endPoint < 0 || midtermScore < 0)
                return 34;

            if (score_DAO.FindScore(teachingId,studentId,registerDate).Count > 0)
            {
                try
                {
                    score_DAO.EditScore(teachingId, studentId, registerDate, midtermScore, midtermScoreDate, endPoint, endPointDate);
                    return 0;
                }
                catch (Exception)
                {
                    return -2;
                } 
            }
            else { return -2; }
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