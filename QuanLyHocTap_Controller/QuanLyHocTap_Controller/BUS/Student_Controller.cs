using QuanLyHocTapData.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
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

        public void GetCBBStudents(ComboBox comboBox)
        {
            comboBox.DataSource = student_DAO.LoadCBBStudents();
            comboBox.DisplayMember = "StudentName";
            comboBox.ValueMember = "StudentID";
        }

        public bool AddStudent(string studentId, string studentName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string classId)
        {
            try
            {
                student_DAO.AddStudent(studentId, studentName, dateOfBirth, cccd, email, phone, address, classId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditStudent(string studentId, string studentName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string classId)
        {

            if (student_DAO.FindStudent(studentId))
            {
                try
                {
                    student_DAO.EditStudent(studentId, studentName, dateOfBirth, cccd, email, phone, address, classId);
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

        public bool DeleteStudent(string studentId)
        {

            if (student_DAO.FindStudent(studentId))
            {
                try
                {
                    student_DAO.DeleteStudent(studentId);
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
