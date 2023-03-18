using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Teaching_Controller
    {
        DAO_Load daoLoad;

        public Teaching_Controller() 
        {
            daoLoad = new DAO_Load();
        }

        public void GetTeachings(DataGridView dataGrirdView, string teacherId)
        {
            dataGrirdView.DataSource = daoLoad.LoadTeachings(teacherId);
        }

        public void GetTeacher(DataGridView dataGridView, string teacherId)
        {
            dataGridView.DataSource = daoLoad.GetTeacher(teacherId);
        }
    }
}
