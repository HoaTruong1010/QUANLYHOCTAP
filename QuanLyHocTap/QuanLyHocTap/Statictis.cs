using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyHocTap.ultils;
using QuanLyHocTap_Controller;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap
{
    public partial class Statictis : Form
    {
        Score_Controller score_Controller;
        Message_Error message_Error;
        private DateTime dateTimeStart;
        private DateTime dateTimeFinish;
        private bool isView = false;

        public DateTime DateTimeFinish { get => dateTimeFinish; set => dateTimeFinish = value; }
        public DateTime DateTimeStart { get => dateTimeStart; set => dateTimeStart = value; }
        public bool IsView { get => isView; set => isView = value; }

        public Statictis()
        {
            InitializeComponent();
            score_Controller = new Score_Controller();
            message_Error = new Message_Error();
            dateTimeFinish = DateTime.Now;
            dateTimeStart = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<ScoreStatictis> list = score_Controller.setChartData(dtpStart.Value, dtpFinish.Value);
            if(list.Count > 0)
            {
                //int sum = 0;
                chartScore.Series["Score"].Points.Clear();
                //foreach (ScoreStatictis score in list)
                //{
                //    sum+=score.SOLUONG;
                //}
                foreach (ScoreStatictis item in list)
                {
                    chartScore.Series["Score"].Points.Add(new DataPoint((double)item.DIEM, item.SOLUONG));
                    //double percent = Math.Round(((double)item.SOLUONG / (double)sum) * 100, 2);
                    chartScore.Legends["LegendScore"].Title = "Điểm";
                }
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(35), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Statictis_Load(object sender, EventArgs e)
        {
            if (!IsView)
            { 
                RequireInputDate frm = new RequireInputDate();
                this.Close();
                frm.ShowDialog();
            }
            else
            {
                dtpStart.Value = dateTimeStart;
                dtpFinish.Value = dateTimeFinish;
                btnView_Click(sender, e);
            } 
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
