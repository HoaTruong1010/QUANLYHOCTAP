using QuanLyHocTap_Controller.BUS;
using QuanLyHocTap.ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyHocTap
{
    public partial class Student : Form
    {
        Student_Controller student_Controller;
        Class_Controller class_Controller;
        Message_Error message_Error;
        ConvertString convertString;

        private string classIDOld;

        public Student()
        {
            InitializeComponent();
            student_Controller = new Student_Controller();
            class_Controller = new Class_Controller();
            message_Error = new Message_Error();
            convertString = new ConvertString();
        }

        private void ShowStudents()
        {
            dgvStudent.DataSource = null;
            student_Controller.GetStudents(dgvStudent);
            dgvStudent.Columns[0].Width = (int)(dgvStudent.Width * 0.075);
            dgvStudent.Columns[1].Width = (int)(dgvStudent.Width * 0.175);
            dgvStudent.Columns[2].Width = (int)(dgvStudent.Width * 0.07);
            dgvStudent.Columns[3].Width = (int)(dgvStudent.Width * 0.09);
            dgvStudent.Columns[4].Width = (int)(dgvStudent.Width * 0.13);
            dgvStudent.Columns[5].Width = (int)(dgvStudent.Width * 0.075);
            dgvStudent.Columns[6].Width = (int)(dgvStudent.Width * 0.2);
            dgvStudent.Columns[7].Width = (int)(dgvStudent.Width * 0.065);
            dgvStudent.Columns[8].Width = (int)(dgvStudent.Width * 0.07);
        }

        private void Reset()
        {
            txtStudentID.Text = txtStudentName.Text = txtStudentCCCD.Text = txtStudentEmail.Text = string.Empty;
            txtSeachStudent.Text = txtStudentPN.Text = txtStudentAddress.Text = string.Empty;
            txtStudentID.Enabled = btAddStudent.Enabled = true;
            btnViewScore.Enabled = btnDeleteStudent.Enabled = btnSaveStudent.Enabled = false;
            cbbClass.SelectedIndex = 0;
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            ShowStudents();
            class_Controller.GetCBBClasses(cbbClass);
            Reset();
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
                classIDOld = dgvStudent.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();

                txtStudentID.Enabled = btAddStudent.Enabled = false;
                btnViewScore.Enabled = btnDeleteStudent.Enabled = btnSaveStudent.Enabled = true;
            }
            else
                Reset();
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            string studentId = convertString.DeleteSpacingID(txtStudentID.Text);
            string studentName = convertString.DeleteSpacing(txtStudentName.Text);
            DateTime dateOfBirth = dtpStudentDOB.Value;
            string id = convertString.DeleteSpacing(txtStudentCCCD.Text);
            string email = convertString.DeleteSpacing(txtStudentEmail.Text);
            string phone = convertString.DeleteSpacing(txtStudentPN.Text);
            string address = convertString.DeleteSpacing(txtStudentAddress.Text);
            string classId = cbbClass.SelectedValue.ToString();
            int result = student_Controller.AddStudent(studentId, studentName, dateOfBirth, id, email, phone, address, classId);

            if (result == 0)
            {
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStudents();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string studentId = convertString.DeleteSpacingID(txtStudentID.Text);
            string studentName = convertString.DeleteSpacing(txtStudentName.Text);
            DateTime dateOfBirth = dtpStudentDOB.Value;
            string id = convertString.DeleteSpacing(txtStudentCCCD.Text);
            string email = convertString.DeleteSpacing(txtStudentEmail.Text);
            string phone = convertString.DeleteSpacing(txtStudentPN.Text);
            string address = convertString.DeleteSpacing(txtStudentAddress.Text);
            string classId = cbbClass.SelectedValue.ToString();
            int result = student_Controller.EditStudent(studentId, studentName, dateOfBirth, id, email, phone, address, classId, classIDOld);

            if (result == 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStudents();
                Reset();
            }
            else
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;

            if (student_Controller.DeleteStudent(studentId, classIDOld))
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStudents();
                Reset();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            Score frmKQHT = new Score();
            frmKQHT.SelectedStudentId = txtStudentID.Text;
            frmKQHT.StartPosition = FormStartPosition.CenterScreen;
            frmKQHT.Width = this.Width;
            frmKQHT.Show();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == string.Empty || txtStudentID.Text.Length < 10)
            {
                MessageBox.Show(message_Error.GetMessage(25), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Focus();
            }
            if (txtStudentID.Text.Length > 10)
            {
                MessageBox.Show(message_Error.GetMessage(26), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Focus();
            }
        }

        private void dtpStudentDOB_DropDown(object sender, EventArgs e)
        {
            if (txtStudentName.Text == string.Empty)
            {
                MessageBox.Show(message_Error.GetMessage(30), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentName.Focus();
            }
            if (txtStudentName.Text.Length > 27)
            {
                MessageBox.Show(message_Error.GetMessage(31), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentName.Focus();
            }
        }

        private void txtStudentCCCD_Click(object sender, EventArgs e)
        {
            TimeSpan timeDifference = DateTime.Now - dtpStudentDOB.Value;
            double age = timeDifference.TotalDays / 365.2425;

            if(age < 17)
            {
                MessageBox.Show(message_Error.GetMessage(28), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStudentDOB.Focus();
            }
        }

        private void txtStudentEmail_Click(object sender, EventArgs e)
        {
            if (txtStudentCCCD.Text.Length != 9 && txtStudentCCCD.Text.Length != 12)
            {
                MessageBox.Show(message_Error.GetMessage(6), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentCCCD.Focus();
            }
        }

        private void txtStudentPN_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            if (!regex.IsMatch(txtStudentEmail.Text))
            {
                MessageBox.Show(message_Error.GetMessage(7), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentEmail.Focus();
            }
        }

        private void txtStudentAddress_Click(object sender, EventArgs e)
        {
            if (txtStudentPN.Text.Length != 9 && txtStudentPN.Text.Length != 10)
            {
                MessageBox.Show(message_Error.GetMessage(11), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentName.Focus();
            }
        }

        private void cbbClass_Click(object sender, EventArgs e)
        {
            if (txtStudentAddress.Text == string.Empty)
            {
                MessageBox.Show(message_Error.GetMessage(8), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentName.Focus();
            }
            if (txtStudentAddress.Text.Length > 100)
            {
                MessageBox.Show(message_Error.GetMessage(9), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentName.Focus();
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string kw = convertString.DeleteSpacing(txtSeachStudent.Text);
            int result = student_Controller.SearchStudent(dgvStudent, kw);

            if(result != 0)
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowStudents();
                Reset();
            }
        }
    }
}
