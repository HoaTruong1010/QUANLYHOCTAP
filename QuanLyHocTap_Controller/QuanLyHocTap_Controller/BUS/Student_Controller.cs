using QuanLyHocTapData.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocTap_Controller.BUS
{
    public class Student_Controller
    {
        Student_DAO student_DAO;

        public Student_Controller()
        {
            student_DAO = new Student_DAO();
        }

        public void GetStudents(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = student_DAO.LoadStudents();
        }

        public void GetStudent(TextBox txtStudentId, TextBox txtStudentName, string studentId)
        {
            Dictionary<string, string> keyValuePairs = student_DAO.GetStudent(studentId);
            foreach (KeyValuePair<string, string> item in keyValuePairs)
            {
                txtStudentId.Text = item.Key;
                txtStudentName.Text = item.Value;
            }
        }

        public int SearchStudent(DataGridView dataGridView, string kw)
        {
            dataGridView.DataSource = student_DAO.SearchStudent(kw);
            if (dataGridView.RowCount == 0)
            {
                return 10;
            }
            return 0;
        }

        public void GetCBBStudents(ComboBox comboBox)
        {
            comboBox.DataSource = student_DAO.LoadCBBStudents();
            comboBox.DisplayMember = "StudentName";
            comboBox.ValueMember = "StudentID";
        }

        public int AddStudent(string studentId, string studentName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string classId)
        {
            TimeSpan timeDifference = DateTime.Now - dateOfBirth;
            double age = timeDifference.TotalDays / 365.2425;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            if (studentId == null || studentId.Length < 10)
                return 25;
            if (studentId.Length > 10)
                return 26;
            if (student_DAO.FindStudent(studentId))
                return 27;
            if (studentName == null)
                return 30;
            if (studentName.Length > 27)
                return 31;
            if (age < 17)
                return 28;
            if (cccd.Length != 9 && cccd.Length != 12)
                return 6;
            if (!regex.IsMatch(email))
                return 7;
            if (phone.Length != 9 && phone.Length != 10)
                return 11;
            if (address == null)
                return 8;
            if (address.Length > 100)
                return 9;
            try
            {
                student_DAO.AddStudent(studentId, studentName, dateOfBirth, cccd, email, phone, address, classId);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int EditStudent(string studentId, string studentName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string classIdNew, string classIdOld)
        {
            TimeSpan timeDifference = DateTime.Now - dateOfBirth;
            double age = timeDifference.TotalDays / 365.2425;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            if (studentName == null)
                return 30;
            if (studentName.Length > 27)
                return 31;
            if (age < 17)
                return 28;
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

            if (student_DAO.FindStudent(studentId))
            {
                try
                {
                    student_DAO.EditStudent(studentId, studentName, dateOfBirth, cccd, email, phone, address, classIdNew, classIdOld);
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

        public bool DeleteStudent(string studentId, string classID)
        {

            if (student_DAO.FindStudent(studentId))
            {
                try
                {
                    student_DAO.DeleteStudent(studentId, classID);
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
