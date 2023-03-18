using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Class_Controller
    {
        DAO_Load daoLoad;

        public Class_Controller() 
        {
            daoLoad = new DAO_Load();
        }

        public void GetClasses(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = daoLoad.LoadClasses();
        }

        public void GetCBBClasses(ComboBox comboBox)
        {
            comboBox.DataSource = daoLoad.LoadCBBClasses();
            comboBox.DisplayMember = "ClassName";
            comboBox.ValueMember = "ClassID";
        }
    }
}
