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
        Teacher_DAO teacher_Dao;

        public Teaching_Controller() 
        {
            teaching_Dao = new Teaching_DAO();
            teacher_Dao = new Teacher_DAO();
        }

        public void GetTeachings(DataGridView dataGrirdView, string teacherId)
        {
            dataGrirdView.DataSource = teaching_Dao.LoadTeachings(teacherId);
        }

        public void GetTeacher(TextBox txtTeacherID, TextBox txtTeacherName, string teacherId)
        {
            Dictionary<string, string> keyValuePairs = teacher_Dao.GetTeacher(teacherId);
            foreach (KeyValuePair <string, string> item in keyValuePairs)
            {
                txtTeacherID.Text = item.Key;
                txtTeacherName.Text = item.Value;
            }
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
