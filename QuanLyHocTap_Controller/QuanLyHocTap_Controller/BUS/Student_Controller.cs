using QuanLyHocTapData.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocTap_Controller.BUS
{
    public class Student_Controller
    {
        Teacher_DAO daoLoad;

        public Student_Controller()
        {
            daoLoad = new Teacher_DAO();
        }

        public void GetStudents(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = daoLoad.LoadStudents();
        }

        public void GetCBBStudents(ComboBox comboBox)
        {
            comboBox.DataSource = daoLoad.LoadCBBStudents();
            comboBox.DisplayMember = "StudentName";
            comboBox.ValueMember = "StudentID";
        }
    }
}
