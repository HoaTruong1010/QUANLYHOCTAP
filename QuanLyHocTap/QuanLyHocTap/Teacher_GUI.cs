using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Controller;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using QuanLyHocTap.ultils;
using System.Text.RegularExpressions;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap
{
    public partial class Teacher_GUI : Form
    {
        Teacher_Controller teacher_controller;
        Message_Error message_Error;
        ConvertString convertString;

        public Teacher_GUI()
        {
            InitializeComponent();
            teacher_controller = new Teacher_Controller();
            message_Error = new Message_Error();
            convertString = new ConvertString();
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

        private void GiangVien_Load(object sender, EventArgs e)
        {
            ShowTeachers();
            Reset();
        }

        private void GiangVien_Click(object sender, EventArgs e)
        {
            Reset();
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

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            string kw = convertString.DeleteSpacing(txtSearchTeacher.Text);
            int result = teacher_controller.SearchTeacher(dgvTeacher, kw);

            if (result != 0)
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowTeachers();
                Reset();
            }
        }

        private void btnTeaching_Click(object sender, EventArgs e)
        {
            Teaching_GUI frmGiangDay = new Teaching_GUI();
            frmGiangDay.TeacherSelectedId = txtTeacherID.Text;
            frmGiangDay.StartPosition = FormStartPosition.CenterScreen;
            frmGiangDay.Show();
        }

        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            string teacherId = convertString.DeleteSpacingID(txtTeacherID.Text);
            string teacherName = convertString.DeleteSpacing(txtTeacherName.Text);
            DateTime dateOfBirth = dtpTeacherDOB.Value;
            string id = convertString.DeleteSpacing(txtTeacherCCCD.Text);
            string email = convertString.DeleteSpacing(txtTeacherEmail.Text);
            string phone = convertString.DeleteSpacing(txtTeacherPN.Text);
            string address = convertString.DeleteSpacing(txtTeacherAddress.Text);
            string certificate = cbbCertificate.SelectedItem.ToString();

            Teacher teacher = new Teacher();
            teacher.TeacherID = teacherId;
            teacher.TeacherName = teacherName;
            teacher.DayOfBirth = dateOfBirth;
            teacher.ID = id;
            teacher.Email = email;
            teacher.Phone = phone;
            teacher.TeacherAddress = address;
            teacher.TeacherCertificate = certificate;
            
            int msgKey = teacher_controller.AddTeacher(teacher);

            if (msgKey == 0) 
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(msgKey), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnSaveTeacher_Click(object sender, EventArgs e)
        {
            string teacherId = convertString.DeleteSpacingID(txtTeacherID.Text);
            string teacherName = convertString.DeleteSpacing(txtTeacherName.Text);
            DateTime dateOfBirth = dtpTeacherDOB.Value;
            string id = convertString.DeleteSpacing(txtTeacherCCCD.Text);
            string email = convertString.DeleteSpacing(txtTeacherEmail.Text);
            string phone = convertString.DeleteSpacing(txtTeacherPN.Text);
            string address = convertString.DeleteSpacing(txtTeacherAddress.Text);
            string certificate = cbbCertificate.SelectedItem.ToString();

            Teacher teacher = new Teacher();
            teacher.TeacherID = teacherId;
            teacher.TeacherName = teacherName;
            teacher.DayOfBirth = dateOfBirth;
            teacher.ID = id;
            teacher.Email = email;
            teacher.Phone = phone;
            teacher.TeacherAddress = address;
            teacher.TeacherCertificate = certificate;

            int msgKey = teacher_controller.EditTeacher(teacher);

            if (msgKey == 0)
            {
                MessageBox.Show("Lưu thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeachers();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(msgKey), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(message_Error.GetMessage(36), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTeacherID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTeacherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTeacherCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}