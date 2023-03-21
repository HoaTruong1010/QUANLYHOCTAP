using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Score_Controller
    {
        Teacher_DAO daoLoad;

        public Score_Controller ()
        {
            daoLoad = new Teacher_DAO();
        }

        public void GetScores(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = daoLoad.LoadScores();
        }
    }
}
