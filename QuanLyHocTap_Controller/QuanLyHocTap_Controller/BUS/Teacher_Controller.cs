using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Teacher_Controller
    {
        DAO_Teacher dao_Teacher;

        public Teacher_Controller()
        {
            dao_Teacher = new DAO_Teacher();
        }

        public void GetAllTeacher(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = dao_Teacher.LoadTeachers();
        }
    }
}
