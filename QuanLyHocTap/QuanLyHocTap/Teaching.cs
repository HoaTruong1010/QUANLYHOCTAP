﻿using QuanLyHocTap_Controller.BUS;
using QuanLyHocTapData.DAO;
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
    public partial class Teaching : Form
    {
        Teaching_Controller teachingController;
        Teacher_Controller teacherController;
        Subject_Controller subjectController;
        Message_Error message_Error;
        private string teacherSelectedId;
        private int teachingID = 0;

        public string TeacherSelectedId { get => teacherSelectedId; set => teacherSelectedId = value; }
        public int TeachingID { get => teachingID; set => teachingID = value; }

        public Teaching()
        {
            InitializeComponent();
            teachingController = new Teaching_Controller();
            subjectController = new Subject_Controller();
            teacherController = new Teacher_Controller();
            message_Error = new Message_Error();
        }

        private void ShowTeaching(string teacherId)
        {
            dgvTeaching.DataSource = null;
            teachingController.GetTeachings(dgvTeaching, teacherId);
            dgvTeaching.Columns[0].Width = (int)(dgvTeaching.Width * 0.125);
            dgvTeaching.Columns[1].Width = (int)(dgvTeaching.Width * 0.2);
            dgvTeaching.Columns[2].Width = (int)(dgvTeaching.Width * 0.35);
            dgvTeaching.Columns[3].Width = (int)(dgvTeaching.Width * 0.24);
        }

        private void Reset()
        {
            txtSearchTeaching.Text = string.Empty;
            btAddTeaching.Enabled = true;
            btnDeleteTeaching.Enabled = btnSaveTeaching.Enabled = false;
            cbSubject.SelectedIndex = 0;
            dtpRegisterDate.Value = DateTime.Now;
        }

        private void GiangDay_Load(object sender, EventArgs e)
        {
            teacherController.GetTeacher(txtTeacherID, txtTeacherName, TeacherSelectedId);
            ShowTeaching(txtTeacherID.Text);
            subjectController.GetCBBSubjects(cbSubject);
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteTeaching_Click(object sender, EventArgs e)
        {
            if (teachingID != 0)
            {
                if (teachingController.DeleteTeaching(teachingID))
                {
                    MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTeaching(txtTeacherID.Text);
                    Reset();
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveTeaching_Click(object sender, EventArgs e)
        {
            if (teachingID != 0)
            {
                string subjectID = cbSubject.SelectedValue.ToString();
                int result = teachingController.EditTeaching(teachingID, teacherSelectedId, subjectID, DateTime.Now);

                if (result == 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTeaching(txtTeacherID.Text);
                    Reset();
                }
                else
                    MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng chọn dòng để sửa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btAddTeaching_Click(object sender, EventArgs e)
        {
            string subjectID = cbSubject.SelectedValue.ToString();
            int result = teachingController.AddTeaching(teacherSelectedId, subjectID, DateTime.Now);

            if (result == 0)
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeaching(txtTeacherID.Text);
                Reset();
            }
            else
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvTeaching_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTeaching.RowCount)
            {
                dtpRegisterDate.Text = dgvTeaching.Rows[e.RowIndex].Cells["RegisterDate"].Value.ToString();
                cbSubject.Text = dgvTeaching.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                teachingID = (int) dgvTeaching.Rows[e.RowIndex].Cells["ID"].Value;

                btAddTeaching.Enabled = false;
                btnDeleteTeaching.Enabled = btnSaveTeaching.Enabled = true;
            }
            else
                Reset();
        }

        private void Teaching_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearchTeaching_Click(object sender, EventArgs e)
        {
            string kw = txtSearchTeaching.Text;
            int result = teachingController.SearchTeaching(dgvTeaching, kw, teacherSelectedId);

            if (result != 0)
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowTeaching(teacherSelectedId);
                Reset();
            }
        }
    }
}
