using QuanLyHocTap_Data;
using QuanLyHocTap_DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyHocTap_Controller
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

        public int AddStudent(Student student)
        {            
            if (student_DAO.FindStudent(student.StudentID))
                return 27;
            int isValidStudent = CheckData.IsValidStudent(student);
            if(isValidStudent == 0)
            {
                try
                {
                    student_DAO.AddStudent(student);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return isValidStudent;            
        }

        public int EditStudent(Student student, string classIdOld)
        {
            int isValidStudent = CheckData.IsValidStudent(student);
            if (isValidStudent == 0)
            {
                if (student_DAO.FindStudent(student.StudentID))
                {
                    try
                    {
                        student_DAO.EditStudent(student, classIdOld);
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
            return isValidStudent;            
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
