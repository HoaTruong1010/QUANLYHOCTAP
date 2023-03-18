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
        DAO_Load daoLoad;

        public Score_Controller ()
        {
            daoLoad = new DAO_Load();
        }

        public void GetScores(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = daoLoad.LoadScores();
        }
    }
}
