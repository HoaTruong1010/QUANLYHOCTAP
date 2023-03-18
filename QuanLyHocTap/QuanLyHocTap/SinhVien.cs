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
    public partial class SinhVien : Form
    {
        Student_Controller getController;
        Class_Controller getClassController;

        public SinhVien()
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
    }
}
