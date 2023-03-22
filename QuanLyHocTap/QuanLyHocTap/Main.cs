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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void exitTMSItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void qlgvTSMItem_Click(object sender, EventArgs e)
        {
            Teacher frmGiangVien = new Teacher();
            frmGiangVien.StartPosition = FormStartPosition.CenterScreen;
            frmGiangVien.Width = 1250;
            frmGiangVien.Height = 650;
            frmGiangVien.Show();
        }

        private void qlmhTSMItem_Click(object sender, EventArgs e)
        {
            Subject fromMonHoc = new Subject();
            fromMonHoc.StartPosition = FormStartPosition.CenterScreen;
            fromMonHoc.Show();  
        }

        private void qllTSMItem_Click(object sender, EventArgs e)
        {
            Classes frmLop = new Classes();
            frmLop.StartPosition = FormStartPosition.CenterScreen;
            frmLop.Show();  
        }

        private void qlsvTSMItem_Click(object sender, EventArgs e)
        {
            Student frmSinhVien = new Student();
            frmSinhVien.StartPosition = FormStartPosition.CenterScreen;
            frmSinhVien.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Courier New");
            lbTitle.Width = ClientRectangle.Width;
            lbTitle.Height = ClientRectangle.Height - menuStrip1.Height;
            lbTitle.Location = new Point(0, menuStrip1.Height);
            lbTitle.Font = new Font(f, 65, FontStyle.Bold);
            menuTool.Font = new Font(f, 20);
            exitTMSItem.Font = new Font(f, 20);
        }
    }
}
