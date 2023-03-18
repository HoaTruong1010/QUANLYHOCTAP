using System;
using System.Collections.Generic;
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
        DAO_Load daoLoad;

        public Teacher_Controller()
        {
            daoLoad = new DAO_Load();
        }

        public void GetAllTeachers(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = daoLoad.LoadTeachers();
        }

        public void GetCBBTeachers(ComboBox comboBox)
        {
            comboBox.DataSource = daoLoad.LoadCBBTeachers();
            comboBox.DisplayMember = "TeacherName";
            comboBox.ValueMember = "TeacherID";
        }
    }
}
