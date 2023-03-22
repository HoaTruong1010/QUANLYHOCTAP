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
    public partial class Teaching : Form
    {
        Teaching_Controller teachingController;
        Teacher_Controller teacherController;
        Subject_Controller subjectController;
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
        }

        private void ShowTeaching(string teacherId)
        {
            dgvTeaching.DataSource = null;
            teachingController.GetTeachings(dgvTeaching, teacherId);
            dgvTeaching.Columns[0].Width = (int)(dgvTeaching.Width * 0.125);
            dgvTeaching.Columns[1].Width = (int)(dgvTeaching.Width * 0.25);
            dgvTeaching.Columns[2].Width = (int)(dgvTeaching.Width * 0.3);
            dgvTeaching.Columns[3].Width = (int)(dgvTeaching.Width * 0.25);
        }

        private void GiangDay_Load(object sender, EventArgs e)
        {
            teacherController.GetTeacher(txtTeacherID, txtTeacherName, TeacherSelectedId);
            ShowTeaching(txtTeacherID.Text);
            subjectController.GetCBBSubjects(cbSubject);
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
                    MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTeaching(txtTeacherID.Text);
                }
                else
                    MessageBox.Show("Xóa không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveTeaching_Click(object sender, EventArgs e)
        {
            if (teachingID != 0)
            {
                string subjectID = cbSubject.SelectedValue.ToString();

                if (teachingController.EditTeaching(teachingID, teacherSelectedId, subjectID, DateTime.Now))
                {
                    MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowTeaching(txtTeacherID.Text);
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng chọn dòng để sửa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btAddTeaching_Click(object sender, EventArgs e)
        {
            string subjectID = cbSubject.SelectedValue.ToString();

            if (teachingController.AddTeaching(teacherSelectedId,subjectID, DateTime.Now))
            {
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowTeaching(txtTeacherID.Text);
            }
            else
                MessageBox.Show("Thêm không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvTeaching_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTeaching.RowCount)
            {
                dtpRegisterDate.Text = dgvTeaching.Rows[e.RowIndex].Cells["RegisterDate"].Value.ToString();
                cbSubject.Text = dgvTeaching.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                teachingID = (int) dgvTeaching.Rows[e.RowIndex].Cells["ID"].Value;
            }
        }
    }
}
