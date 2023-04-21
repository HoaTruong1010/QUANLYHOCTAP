using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Data;
using QuanLyHocTap_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyHocTap_Controller
{
    public class Teacher_Controller
    {
        Teacher_DAO teacher_Dao;

        public Teacher_Controller()
        {
            teacher_Dao = new Teacher_DAO();
        }

        public void GetAllTeachers(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = teacher_Dao.LoadTeachers();
        }

        public void GetTeacher(TextBox txtTeacherID, TextBox txtTeacherName, string teacherId)
        {
            Dictionary<string, string> keyValuePairs = teacher_Dao.GetTeacher(teacherId);
            foreach (KeyValuePair<string, string> item in keyValuePairs)
            {
                txtTeacherID.Text = item.Key;
                txtTeacherName.Text = item.Value;
            }
        }

        public int SearchTeacher(DataGridView dataGridView, string kw)
        {
            dataGridView.DataSource = teacher_Dao.SearchTeacher(kw);
            if(dataGridView.RowCount == 0)
            {
                return 10;
            }
            return 0;
        }

        public void GetCBBTeachers(ComboBox comboBox)
        {
            comboBox.DataSource = teacher_Dao.LoadCBBTeachers();
            comboBox.DisplayMember = "TeacherName";
            comboBox.ValueMember = "TeacherID";
        }

        public int AddTeacher(Teacher teacher)
        {
            if (teacher_Dao.FindTeacher(teacher.TeacherID))
                return 12;

            int isValidTeacher = CheckData.IsValidTeacher(teacher);
            
            if(isValidTeacher == 0)
            {
                try
                {
                    teacher_Dao.AddTeacher(teacher);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return isValidTeacher;
        }

        public int EditTeacher(Teacher teacher)
        {
            int isValidTeacher = CheckData.IsValidTeacher(teacher);

            if (isValidTeacher == 0)
            {
                if (teacher_Dao.FindTeacher(teacher.TeacherID))
                {
                    try
                    {
                        teacher_Dao.EditTeacher(teacher);
                    }
                    catch (DbUpdateException)
                    {
                        return -2;
                    }
                }
                else
                    return -2;
            }
            return isValidTeacher;
        }

        public bool DeleteTeacher(string teacherId)
        {

            if (teacher_Dao.FindTeacher(teacherId))
            {
                try
                {
                    teacher_Dao.DeleteTeacher(teacherId);
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
