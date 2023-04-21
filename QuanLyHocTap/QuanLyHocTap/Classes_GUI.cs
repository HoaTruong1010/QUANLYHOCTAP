using QuanLyHocTap_Controller;
using QuanLyHocTap.ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyHocTap
{
    public partial class Classes_GUI : Form
    {
        Class_Controller class_Controller; 
        Message_Error message_Error;
        Teacher_Controller teacher_Controller;
        ConvertString convertString;

        public Classes_GUI()
        {
            InitializeComponent();
            class_Controller = new Class_Controller();
            teacher_Controller = new Teacher_Controller();
            convertString = new ConvertString();
            message_Error = new Message_Error();
        }

        private void Reset()
        {
            txtSearchClass.Text = txtClassID.Text = txtClassName.Text = string.Empty;
            txtClassID.Enabled = btAddClass.Enabled = true;
            btnDeleteClass.Enabled = btnSaveClass.Enabled = false;
            cbbTeacher.SelectedIndex = 0;
        }

        private void ShowClasses()
        {
            dgvClass.DataSource = null;
            class_Controller.GetClasses(dgvClass);
            dgvClass.Columns[0].Width = (int)(dgvClass.Width * 0.16);
            dgvClass.Columns[1].Width = (int)(dgvClass.Width * 0.16);
            dgvClass.Columns[2].Width = (int)(dgvClass.Width * 0.25);
            dgvClass.Columns[3].Width = (int)(dgvClass.Width * 0.16);
            dgvClass.Columns[4].Width = (int)(dgvClass.Width * 0.16);
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            ShowClasses();
            teacher_Controller.GetCBBTeachers(cbbTeacher);
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvClass.RowCount)
            {
                txtClassID.Text = dgvClass.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
                txtClassName.Text = dgvClass.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
                nbuNumStudent.Value = (int)dgvClass.Rows[e.RowIndex].Cells["TotalStudent"].Value;
                if (dgvClass.Rows[e.RowIndex].Cells["TeacherName"].Value == null)
                {
                    cbbTeacher.SelectedItem = "";
                }
                else
                {
                    cbbTeacher.Text = dgvClass.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();
                }

                txtClassID.Enabled = btAddClass.Enabled = false;
                btnDeleteClass.Enabled = btnSaveClass.Enabled = true;
            }
            else
                Reset();
        }

        private void btAddClass_Click(object sender, EventArgs e)
        {
            string classId = convertString.DeleteSpacingID(txtClassID.Text);
            string className = convertString.DeleteSpacing(txtClassName.Text);
            int total = (int) nbuNumStudent.Value;
            string teacherId = cbbTeacher.SelectedValue.ToString();
            int result = class_Controller.AddClass(classId, className, total, teacherId);

            if (result == 0)
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowClasses();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassID.Text;

            if (class_Controller.DeleteCLass(classId))
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowClasses();
                Reset();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassID.Text;
            string className = convertString.DeleteSpacing(txtClassName.Text);
            int total = (int)nbuNumStudent.Value;
            string teacherId = cbbTeacher.SelectedValue.ToString();
            int result = class_Controller.EditCLass(classId, className, total, teacherId);

            if (result == 0)
            {
                MessageBox.Show("Sửa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowClasses();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            if (txtClassID.Text == String.Empty || txtClassID.Text.Length < 8)
            {
                MessageBox.Show(message_Error.GetMessage(19), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassID.Focus();
            }
            if (txtClassID.Text.Length > 8)
            {
                MessageBox.Show(message_Error.GetMessage(20), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassID.Focus();
            }
        }

        private void cbbTeacher_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text == String.Empty)
            {
                MessageBox.Show(message_Error.GetMessage(22), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassName.Focus();
            }
            if (txtClassName.Text.Length > 20)
            {
                MessageBox.Show(message_Error.GetMessage(23), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassName.Focus();
            }
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            string kw = convertString.DeleteSpacing(txtSearchClass.Text);
            int result = class_Controller.SearchClass(dgvClass, kw);
            if (result != 0)
            {
                MessageBox.Show(message_Error.GetMessage(10), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowClasses();
                Reset();
            }
        }
    }
}
