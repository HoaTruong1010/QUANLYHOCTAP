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
    public partial class Lop : Form
    {
        Class_Controller getController; 
        Teacher_Controller tc;

        public Lop()
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
    }
}
