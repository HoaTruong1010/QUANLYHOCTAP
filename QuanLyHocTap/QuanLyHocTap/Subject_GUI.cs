﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Controller;
using QuanLyHocTap.ultils;

namespace QuanLyHocTap
{
    public partial class Subject_GUI : Form
    {
        private Subject_Controller subject_Controller;
        Message_Error message_Error;
        private ConvertString convertString;

        public Subject_GUI()
        {
            InitializeComponent();
            subject_Controller = new Subject_Controller();
            message_Error = new Message_Error();
            convertString = new ConvertString();
        }

        private void ShowSubjects()
        {
            dgvSubject.DataSource = null;
            subject_Controller.GetSubjects(dgvSubject);
            dgvSubject.Columns[0].Width = (int)(dgvSubject.Width * 0.16);
            dgvSubject.Columns[1].Width = (int)(dgvSubject.Width * 0.6);
            dgvSubject.Columns[2].Width = (int)(dgvSubject.Width * 0.16);
        }

        private void Reset()
        {
            txtSearchSubject.Text = txtSubjectID.Text = txtSubjectName.Text = "";
            txtSubjectID.Enabled = btAddSubject.Enabled = true;
            btnSaveSubject.Enabled = btnDeleteSubject.Enabled = false;
            cbbCredits.SelectedIndex = 0;
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            ShowSubjects();
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSubject.RowCount)
            {
                txtSubjectID.Text = dgvSubject.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString();
                txtSubjectName.Text = dgvSubject.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                cbbCredits.Text = dgvSubject.Rows[e.RowIndex].Cells["Credits"].Value.ToString();

                txtSubjectID.Enabled = btAddSubject.Enabled = false;
                btnSaveSubject.Enabled = btnDeleteSubject.Enabled = true;
            }
            else
                Reset();
        }

        private void btAddSubject_Click(object sender, EventArgs e)
        {
            string subjectId = convertString.DeleteSpacingID(txtSubjectID.Text);
            string subjectName = convertString.DeleteSpacing(txtSubjectName.Text);
            double credits = Double.Parse(cbbCredits.SelectedItem.ToString());
            int result = subject_Controller.AddSubject(subjectId, subjectName, credits);

            if (result == 0)
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowSubjects();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            string subjectId = txtSubjectID.Text;

            if (subject_Controller.DeleteSubject(subjectId))
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowSubjects();
                Reset();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            string subjectId = convertString.DeleteSpacingID(txtSubjectID.Text);
            string subjectName = convertString.DeleteSpacing(txtSubjectName.Text);
            double credits = Double.Parse(cbbCredits.SelectedItem.ToString());
            int result = subject_Controller.EditSubject(subjectId, subjectName, credits);

            if (result == 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowSubjects();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Subject_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            string kw = convertString.DeleteSpacing(txtSearchSubject.Text);
            int result = subject_Controller.SearchTeacher(dgvSubject, kw);

            if (result != 0)
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowSubjects();
                Reset();
            }
        }
    }
}