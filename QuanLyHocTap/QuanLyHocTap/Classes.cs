using QuanLyHocTap_Controller.BUS;
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
    public partial class Classes : Form
    {
        Class_Controller getController; 
        Teacher_Controller tc;

        public Classes()
        {
            InitializeComponent();
            getController = new Class_Controller();
            tc = new Teacher_Controller();
        }
        private void ShowClasses()
        {
            dgvClass.DataSource = null;
            getController.GetClasses(dgvClass);
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            ShowClasses();
            tc.GetCBBTeachers(cbbTeacher);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvClass.RowCount)
            {
                txtClassID.Text = dgvClass.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
                txtClassName.Text = dgvClass.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
                nbuNumStudent.Value = Int32.Parse(dgvClass.Rows[e.RowIndex].Cells["TotalStudent"].Value.ToString());
                cbbTeacher.Text = dgvClass.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString(); 
            }
        }

        private void btAddClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassID.Text;
            string className = txtClassName.Text;
            int total = (int) nbuNumStudent.Value;
            string teacherId = cbbTeacher.SelectedValue.ToString();

            if (getController.AddClass(classId, className, total, teacherId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowClasses();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassID.Text;

            if (getController.DeleteCLass(classId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowClasses();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassID.Text;
            string className = txtClassName.Text;
            int total = (int)nbuNumStudent.Value;
            string teacherId = cbbTeacher.SelectedValue.ToString();

            if (getController.EditCLass(classId, className, total, teacherId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowClasses();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
