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
using QuanLyHocTapData.DAO;
using System.Text.RegularExpressions;

namespace QuanLyHocTap
{
    public partial class Teacher : Form
    {
        Teacher_Controller teacher_controller;
        Message_Error message;

        public Teacher()
        {
            InitializeComponent();
            teacher_controller = new Teacher_Controller();
            message = new Message_Error();
        }

        private void Reset()
        {
            txtTeacherID.Enabled = true;
            btAddTeacher.Enabled = true;
            btnDeleteTeacher.Enabled = false;
            btnSaveTeacher.Enabled = false;
            btnTeaching.Enabled = false;
            txtTeacherID.Text = txtTeacherName.Text = txtTeacherCCCD.Text = txtSearchTeacher.Text = "";
            txtTeacherEmail.Text = txtTeacherPN.Text = txtTeacherAddress.Text = "";
            cbbCertificate.SelectedIndex = 0;
            dtpTeacherDOB.Value = DateTime.Now;
        }

        private void ShowTeachers()
        {
            dgvTeacher.DataSource = null;
            teacher_controller.GetAllTeachers(dgvTeacher);
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
            Reset();
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
                cbbCertificate.Text = dgvTeacher.Rows[e.RowIndex].Cells["TeacherCertificate"].Value.ToString();

                btAddTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = true;
                btnSaveTeacher.Enabled = true;
                btnTeaching.Enabled = true;
                txtTeacherID.Enabled = false;
            }
            else
            {
                Reset();
            }
        }

        private void btnTeaching_Click(object sender, EventArgs e)
        {
            Teaching frmGiangDay = new Teaching();
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
            string certificate = cbbCertificate.SelectedItem.ToString();
            int msgKey = teacher_controller.AddTeacher(teacherId, teacherName, dateOfBirth, id, email, phone, address, certificate);

            if (msgKey == 0) 
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
                Reset();
            }
            else
            {
                MessageBox.Show(message.GetMessage(msgKey), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string certificate = cbbCertificate.SelectedItem.ToString();
            int msgKey = teacher_controller.EditTeacher(teacherId, teacherName, dateOfBirth, id, email, phone, address, certificate);

            if (msgKey == 0)
            {
                MessageBox.Show("Lưu thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
                Reset();
            }
            else
            {
                MessageBox.Show(message.GetMessage(msgKey), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            string teacherId = txtTeacherID.Text;

            if (teacher_controller.DeleteTeacher(teacherId))
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
                Reset();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GiangVien_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            if(txtTeacherID.Text.Length == 0 || txtTeacherID.Text.Length < 8)
            {
                MessageBox.Show(message.GetMessage(1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherID.Focus();
            }
            if(txtTeacherID.Text.Length > 8)
            {
                MessageBox.Show(message.GetMessage(2), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherID.Focus();
            }
        }

        private void dtpTeacherDOB_DropDown(object sender, EventArgs e)
        {
            if (txtTeacherName.Text.Length == 0)
            {
                MessageBox.Show(message.GetMessage(3), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherName.Focus();
            }
            if (txtTeacherName.Text.Length > 27)
            {
                MessageBox.Show(message.GetMessage(4), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherName.Focus();
            }
        }

        private void txtTeacherCCCD_Click(object sender, EventArgs e)
        {
            TimeSpan timeDifference = DateTime.Now - dtpTeacherDOB.Value;
            double age = timeDifference.TotalDays / 365.2425;

            if (age < 18)
            {
                MessageBox.Show(message.GetMessage(5), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpTeacherDOB.Focus();
            }
        }

        private void txtTeacherEmail_Click(object sender, EventArgs e)
        {
            if (txtTeacherCCCD.Text.Length != 9 && txtTeacherCCCD.Text.Length != 12)
            {
                MessageBox.Show(message.GetMessage(6), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherCCCD.Focus();
            }
        }

        private void txtTeacherPN_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            if (!regex.IsMatch(txtTeacherEmail.Text))
            {
                MessageBox.Show(message.GetMessage(7), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherEmail.Focus();
            }
        }

        private void txtTeacherAddress_Click(object sender, EventArgs e)
        {
            if(txtTeacherPN.Text.Length != 9 && txtTeacherPN.Text.Length != 10)
            {
                MessageBox.Show(message.GetMessage(11), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherPN.Focus();
            }
        }

        private void cbbCertificate_Click(object sender, EventArgs e)
        {
            if(txtTeacherAddress.Text.Length == 0)
            {
                MessageBox.Show(message.GetMessage(8), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherAddress.Focus();
            }
            if (txtTeacherAddress.Text.Length > 100)
            {
                MessageBox.Show(message.GetMessage(9), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherAddress.Focus();
            }
        }

        private void txtTeacherCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            string kw = txtSearchTeacher.Text;
            int result = teacher_controller.SearchTeacher(dgvTeacher, kw);

            if (result != 0)
            {
                MessageBox.Show(message.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowTeachers();
                Reset();
            }
        }
    }
}