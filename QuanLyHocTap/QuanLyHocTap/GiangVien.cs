using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Controller.BUS;
using System.Configuration;

namespace QuanLyHocTap
{
    public partial class GiangVien : Form
    {
        Teacher_Controller getController;

        public GiangVien()
        {
            InitializeComponent();
            getController = new Teacher_Controller();
        }

        private void ShowTeachers()
        {
            dgvTeacher.DataSource = null;
            getController.GetAllTeachers(dgvTeacher);
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            ShowTeachers();
            gbList.Width = ClientRectangle.Width - 50;
            gbList.Height = ClientRectangle.Height*50/100;
            gbItem.Width = ClientRectangle.Width - 50;
            gbItem.Height = ClientRectangle.Height*30/100;
            gbList.Location = new Point(20, ClientRectangle.Height/40);
            gbItem.Location = new Point(20, (ClientRectangle.Height/30)*17);
            groupBox1.Height = ClientRectangle.Height*20/100;
            groupBox1.Location = new Point(ClientRectangle.Right/2, ClientRectangle.Height*7/8);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTeacher.RowCount)
            {
                txtTeacherID.Text = dgvTeacher.Rows[e.RowIndex].Cells["TeacherID"].Value.ToString();
                txtTeacherName.Text = dgvTeacher.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();
                dtpTeacherDOB.Text = dgvTeacher.Rows[e.RowIndex].Cells["DayOfBirth"].Value.ToString();
                txtTeacherCCCD.Text = dgvTeacher.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtTeacherEmail.Text = dgvTeacher.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtTeacherPN.Text = dgvTeacher.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtTeacherAddress.Text = dgvTeacher.Rows[e.RowIndex].Cells["TeacherAddress"].Value.ToString();
                txtTeacherCerti.Text = dgvTeacher.Rows[e.RowIndex].Cells["TeacherCertificate"].Value.ToString(); 

                btnTeaching.Enabled = true;
            }
            else
                btnTeaching.Enabled = false;
        }

        private void btnTeaching_Click(object sender, EventArgs e)
        {
            GiangDay frmGiangDay = new GiangDay();
            frmGiangDay.TeacherSelectedId = txtTeacherID.Text;
            frmGiangDay.Show();
        }
    }
}
