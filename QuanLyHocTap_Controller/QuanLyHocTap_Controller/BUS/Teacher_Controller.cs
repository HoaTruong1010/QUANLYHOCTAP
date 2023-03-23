using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
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

        public int AddTeacher(string teacherId, string teacherName,
            DateTime dateOfBirth, string cccd, string email, string phone, 
            string address, string certificate)
        {
            TimeSpan timeDifference = DateTime.Now - dateOfBirth;
            double age = timeDifference.TotalDays / 365.2425;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            if (teacherId == null || teacherId.Length < 8)
                return 1;
            if (teacherId.Length > 8)
                return 2;
            if (teacherName == null)
                return 3;
            if (teacherName.Length > 27)
                return 4;
            if (age < 18)
                return 5;
            if (cccd.Length != 9 && cccd.Length != 12)
                return 6;
            if (!regex.IsMatch(email))
                return 7;
            if (address == null)
                return 8;
            if (address.Length > 100)
                return 9;
            if (phone.Length != 9 && phone.Length != 10)
                return 11;
            if(teacher_Dao.FindTeacher(teacherId))
                return 12;
            try
            {
                teacher_Dao.AddTeacher(teacherId, teacherName, dateOfBirth, cccd, email, phone, address, certificate);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int EditTeacher(string teacherId, string teacherName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string certificate)
        {
            TimeSpan timeDifference = DateTime.Now - dateOfBirth;
            double age = timeDifference.TotalDays / 365.2425;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            if (teacherName.Length > 27)
                return 4;
            if (age < 18)
                return 5;
            if (cccd.Length != 9 && cccd.Length != 12)
                return 6;
            if (!regex.IsMatch(email))
                return 7;
            if (address == null)
                return 8;
            if (address.Length > 100)
                return 9;
            if (phone.Length != 9 && phone.Length != 10)
                return 11;

            if (teacher_Dao.FindTeacher(teacherId))
            {
                try
                {
                    teacher_Dao.EditTeacher(teacherId, teacherName, dateOfBirth,
                    cccd, email, phone, address, certificate);
                    return 0;
                }
                catch (DbUpdateException)
                {
                    return -2;
                }
            }
            else 
                return -2;
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
