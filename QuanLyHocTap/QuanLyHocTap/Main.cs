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
            GiangVien frmGiangVien = new GiangVien();
            frmGiangVien.MdiParent = this;
            frmGiangVien.Width = this.Width;
            frmGiangVien.Height = this.Height - menuStrip1.Height;
            frmGiangVien.Show();
        }

        private void qlmhTSMItem_Click(object sender, EventArgs e)
        {
            MonHoc fromMonHoc = new MonHoc();
            fromMonHoc.MdiParent = this;
            fromMonHoc.Width = this.Width;
            fromMonHoc.Height = this.Height - menuStrip1.Height;
            fromMonHoc.Show();  
        }

        private void qllTSMItem_Click(object sender, EventArgs e)
        {
            Lop frmLop = new Lop();
            frmLop.MdiParent = this;
            frmLop.Width = this.Width;
            frmLop.Height = this.Height - menuStrip1.Height;
            frmLop.Show();  
        }

        private void qlsvTSMItem_Click(object sender, EventArgs e)
        {
            SinhVien frmSinhVien = new SinhVien();
            frmSinhVien.MdiParent = this;
            frmSinhVien.Width = this.Width;
            frmSinhVien.Height = this.Height - menuStrip1.Height;
            frmSinhVien.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FontFamily f = new FontFamily("Courier New");
            /*lbTitle.Width = ClientRectangle.Width;
            lbTitle.Height = ClientRectangle.Height - menuTool.Height;
            lbTitle.Font = new Font(f, 40);*/
            menuTool.Font = new Font(f, 13);
            exitTMSItem.Font = new Font(f, 13);
        }
    }
}
