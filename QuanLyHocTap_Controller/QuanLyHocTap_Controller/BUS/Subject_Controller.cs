using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Subject_Controller
    {
        DAO_Load daoLoad;

        public Subject_Controller()
        {
            daoLoad = new DAO_Load();
        }

        public void GetSubjects(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = daoLoad.LoadSubjects();
        }

        public void GetCBBSubjects(ComboBox comboBox)
        {
            comboBox.DataSource = daoLoad.LoadCBBSubjects();
            comboBox.DisplayMember = "SubjectName";
            comboBox.ValueMember = "SubjectID";
        }
    }
}
