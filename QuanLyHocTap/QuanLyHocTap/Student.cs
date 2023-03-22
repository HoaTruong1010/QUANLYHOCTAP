using QuanLyHocTap_Controller.BUS;
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
    public partial class Student : Form
    {
        Student_Controller getController;
        Class_Controller getClassController;

        public Student()
        {
            InitializeComponent();
            getController = new Student_Controller();
            getClassController = new Class_Controller();
        }

        private void ShowStudents()
        {
            dgvStudent.DataSource = null;
            getController.GetStudents(dgvStudent);
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            ShowStudents();
            getClassController.GetCBBClasses(cbbClass);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudent.RowCount) 
            {
                txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                txtStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                dtpStudentDOB.Text = dgvStudent.Rows[e.RowIndex].Cells["DayOfBirth"].Value.ToString();
                txtStudentCCCD.Text = dgvStudent.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtStudentEmail.Text = dgvStudent.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtStudentPN.Text = dgvStudent.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtStudentAddress.Text = dgvStudent.Rows[e.RowIndex].Cells["StudentAddress"].Value.ToString();
                cbbClass.Text = dgvStudent.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
            }
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            DateTime dateOfBirth = dtpStudentDOB.Value;
            string id = txtStudentCCCD.Text;
            string email = txtStudentEmail.Text;
            string phone = txtStudentPN.Text;
            string address = txtStudentAddress.Text;
            string classId = cbbClass.SelectedValue.ToString();

            if (getController.AddStudent(studentId, studentName, dateOfBirth, id, email, phone, address, classId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStudents();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            DateTime dateOfBirth = dtpStudentDOB.Value;
            string id = txtStudentCCCD.Text;
            string email = txtStudentEmail.Text;
            string phone = txtStudentPN.Text;
            string address = txtStudentAddress.Text;
            string classId = cbbClass.SelectedValue.ToString();

            if (getController.EditStudent(studentId, studentName, dateOfBirth, id, email, phone, address, classId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStudents();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;

            if (getController.DeleteStudent(studentId))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStudents();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            Score frmKQHT = new Score();
            frmKQHT.SelectedStudentId = txtStudentID.Text;
            frmKQHT.StartPosition = FormStartPosition.CenterScreen;
            frmKQHT.Show();
        }
    }
}
