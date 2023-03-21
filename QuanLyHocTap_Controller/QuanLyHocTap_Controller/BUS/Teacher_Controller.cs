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

        public void GetCBBTeachers(ComboBox comboBox)
        {
            comboBox.DataSource = teacher_Dao.LoadCBBTeachers();
            comboBox.DisplayMember = "TeacherName";
            comboBox.ValueMember = "TeacherID";
        }

        public bool AddTeacher(string teacherId, string teacherName,
            DateTime dateOfBirth, string cccd, string email, string phone, 
            string address, string certificate)
        {
            try
            {
                teacher_Dao.AddTeacher(teacherId, teacherName, dateOfBirth, cccd, email, phone, address, certificate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditTeacher(string teacherId, string teacherName,
            DateTime dateOfBirth, string cccd, string email, string phone,
            string address, string certificate)
        {
            
            if (teacher_Dao.FindTeacher(teacherId))
            {
                try
                {
                    teacher_Dao.EditTeacher(teacherId, teacherName, dateOfBirth,
                    cccd, email, phone, address, certificate);
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
