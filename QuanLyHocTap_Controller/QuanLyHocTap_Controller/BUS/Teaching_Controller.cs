using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Teaching_Controller
    {
        Teaching_DAO teaching_Dao;

        public Teaching_Controller() 
        {
            teaching_Dao = new Teaching_DAO();
        }

        public void GetTeachings(DataGridView dataGrirdView, string teacherId)
        {
            dataGrirdView.DataSource = teaching_Dao.LoadTeachings(teacherId);
        }

        public void GetTeacherByTeachingId(TextBox txtTeacherID,ComboBox cbbTeacher, int id)
        {
            Dictionary<string, string> keyValuePairs = teaching_Dao.FindTeacherByTeachingId(id);
            foreach (KeyValuePair<string, string> item in keyValuePairs)
            {
                txtTeacherID.Text = item.Key;
                cbbTeacher.Text = item.Value;
            }
        }

        public void GetSubjectByTeachingId(TextBox txtSubject,ComboBox cbbSubject, int id)
        {
            Dictionary<string, string> keyValuePairs = teaching_Dao.FindSubjectByTeachingId(id);
            foreach (KeyValuePair<string, string> item in keyValuePairs)
            {
                txtSubject.Text = item.Key;
                cbbSubject.Text = item.Value;
            }
        }

        public int GetTeaching(string subjectId, string teacherId) 
        {
            int id = -1;
            Dictionary<int, DateTime> teaching = teaching_Dao.FindTeaching(subjectId, teacherId);
            if (teaching == null)
                id = 0;
            else
                foreach (KeyValuePair<int, DateTime> item in teaching)
                    id = item.Key;
            return id;
        }

        public void LoadCBBTeacherBySubjectID(ComboBox comboBox, string subjectId, DateTime registerDate)
        {
            comboBox.DataSource = teaching_Dao.LoadCBBTeachersBySubjectID(subjectId, registerDate);
            comboBox.DisplayMember = "TeacherName";
            comboBox.ValueMember = "TeacherID";
        }

        public int SearchTeaching(DataGridView dataGridView, string kw, string teacherID)
        {
            dataGridView.DataSource = teaching_Dao.SearchTeaching(kw, teacherID);
            if(dataGridView.RowCount > 0)
            {
                return 0;
            }
            return 10;
        }

        public int AddTeaching(string teacherID,
            string subjectID, DateTime registerDate)
        {
            Dictionary<int, DateTime> teaching = teaching_Dao.FindTeaching(subjectID, teacherID);
            if (teaching.Count > 0)
            {
                DateTime oldRegisterDate = DateTime.Now;

                foreach (KeyValuePair<int, DateTime> item in teaching)
                    oldRegisterDate = item.Value;

                TimeSpan timeDifference = DateTime.Now - oldRegisterDate;
                double weeks = timeDifference.TotalDays / 7;
                if (weeks < 12)
                    return 32;
            }    

            try
            {
                teaching_Dao.AddTeaching(teacherID, subjectID, registerDate);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool DeleteTeaching(int id)
        {

            if (teaching_Dao.FindTeaching(id))
            {
                try
                {
                    teaching_Dao.DeleteTeaching(id);
                    return true;
                }
                catch (DbUpdateException)
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
