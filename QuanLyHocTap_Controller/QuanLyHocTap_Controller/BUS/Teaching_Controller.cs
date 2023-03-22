using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Dictionary<int, string> teaching = teaching_Dao.FindTeaching(subjectId, teacherId);
            if (teaching == null)
                id = 0;
            else
                foreach (KeyValuePair<int, string> item in teaching)
                    id = item.Key;
            return id;
        }

        public bool AddTeaching(string teacherID,
            string subjectID, DateTime registerDate)
        {
            try
            {
                teaching_Dao.AddTeaching(teacherID, subjectID, registerDate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditTeaching(int id, string teacherID,
            string subjectID, DateTime registerDate)
        {

            if (teaching_Dao.FindTeaching(id))
            {
                try
                {
                    teaching_Dao.EditTeaching(id, teacherID, subjectID, registerDate);
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
