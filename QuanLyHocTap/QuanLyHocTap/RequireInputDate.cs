using QuanLyHocTap.ultils;
using QuanLyHocTap_Controller;
using QuanLyHocTap_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocTap
{
    public partial class RequireInputDate : Form
    {
        Score_Controller score_Controller;
        Message_Error message_Error;

        public RequireInputDate()
        {
            InitializeComponent();
            score_Controller = new Score_Controller();
            message_Error = new Message_Error();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<ScoreStatictis> list = score_Controller.SetChartData(dtpFrom.Value, dtpTo.Value);
            if(list.Count > 0 )
            {
                Statictis frmStatictis = new Statictis();
                frmStatictis.IsView = true;
                frmStatictis.DateTimeStart = dtpFrom.Value;
                frmStatictis.DateTimeFinish = dtpTo.Value;
                this.Close();
                frmStatictis.ShowDialog();
            }
            else 
            { 
                MessageBox.Show(message_Error.GetMessage(35), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
    }
}
