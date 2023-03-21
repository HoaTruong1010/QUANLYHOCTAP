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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

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
            dgvTeacher.Columns[0].Width = (int)(dgvTeacher.Width * 0.08);
            dgvTeacher.Columns[1].Width = (int)(dgvTeacher.Width * 0.09);
            dgvTeacher.Columns[2].Width = (int)(dgvTeacher.Width * 0.09);
            dgvTeacher.Columns[3].Width = (int)(dgvTeacher.Width * 0.1);
            dgvTeacher.Columns[4].Width = (int)(dgvTeacher.Width * 0.15);
            dgvTeacher.Columns[5].Width = (int)(dgvTeacher.Width * 0.09);
            dgvTeacher.Columns[6].Width = (int)(dgvTeacher.Width * 0.2025);
            dgvTeacher.Columns[7].Width = (int)(dgvTeacher.Width * 0.14);
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            ShowTeachers();
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
            frmGiangDay.StartPosition = FormStartPosition.CenterScreen;
            frmGiangDay.Show();
        }

        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            string teacherId = txtTeacherID.Text;
            string teacherName = txtTeacherName.Text;
            DateTime dateOfBirth = dtpTeacherDOB.Value;
            string id = txtTeacherCCCD.Text;
            string email = txtTeacherEmail.Text;
            string phone = txtTeacherPN.Text;
            string address = txtTeacherAddress.Text;
            string certificate = txtTeacherCerti.Text;

            if (getController.AddTeacher(teacherId, teacherName, dateOfBirth, id, email, phone, address, certificate)) 
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnSaveTeacher_Click(object sender, EventArgs e)
        {
            string teacherId = txtTeacherID.Text;
            string teacherName = txtTeacherName.Text;
            DateTime dateOfBirth = dtpTeacherDOB.Value;
            string id = txtTeacherCCCD.Text;
            string email = txtTeacherEmail.Text;
            string phone = txtTeacherPN.Text;
            string address = txtTeacherAddress.Text;
            string certificate = txtTeacherCerti.Text;

            if (getController.EditTeacher(teacherId, teacherName, dateOfBirth, id, email, phone, address, certificate))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            string teacherId = txtTeacherID.Text;

            if (getController.DeleteTeacher(teacherId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
