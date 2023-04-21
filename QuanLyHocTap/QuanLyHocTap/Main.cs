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

        bool _authenticated = false;

        public bool Authenticated { get => _authenticated; set => _authenticated = value; }

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
            Teacher_GUI frmGiangVien = new Teacher_GUI();
            frmGiangVien.StartPosition = FormStartPosition.CenterScreen;
            frmGiangVien.Width = 1250;
            frmGiangVien.Height = 650;
            frmGiangVien.ShowDialog();
        }

        private void qlmhTSMItem_Click(object sender, EventArgs e)
        {
            Subject_GUI fromMonHoc = new Subject_GUI();
            fromMonHoc.StartPosition = FormStartPosition.CenterScreen;
            fromMonHoc.ShowDialog();  
        }

        private void qllTSMItem_Click(object sender, EventArgs e)
        {
            Classes_GUI frmLop = new Classes_GUI();
            frmLop.StartPosition = FormStartPosition.CenterScreen;
            frmLop.ShowDialog();  
        }

        private void qlsvTSMItem_Click(object sender, EventArgs e)
        {
            Student_GUI frmSinhVien = new Student_GUI();
            frmSinhVien.StartPosition = FormStartPosition.CenterScreen;
            frmSinhVien.ShowDialog();
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
            if (!_authenticated)
            {
                Login_GUI frm = new Login_GUI();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void viewStatictis_Click(object sender, EventArgs e)
        {
            Statictis frmStatictis = new Statictis();  
            frmStatictis.Show();
        }
    }
}
