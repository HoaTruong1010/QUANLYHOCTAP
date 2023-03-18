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
    public partial class GiangDay : Form
    {
        Teaching_Controller teachingController;
        Subject_Controller subjectController;
        private string teacherSelectedId;

        public string TeacherSelectedId { get => teacherSelectedId; set => teacherSelectedId = value; }

        public GiangDay()
        {
            InitializeComponent();
            teachingController = new Teaching_Controller();
            subjectController = new Subject_Controller();
        }

        private void ShowTeaching(string teacherId)
        {
            dgvTeaching.DataSource = null;
            teachingController.GetTeachings(dgvTeaching, teacherId);
        }

        private void GiangDay_Load(object sender, EventArgs e)
        {
            teachingController.GetTeacher(dgvTeacherInfo, teacherSelectedId);
            ShowTeaching(dgvTeacherInfo.Rows[0].Cells["TeacherId"].Value.ToString());
            subjectController.GetCBBSubjects(cbSubject);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteTeaching_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveTeaching_Click(object sender, EventArgs e)
        {

        }

        private void btAddTeaching_Click(object sender, EventArgs e)
        {

        }

        private void dgvTeaching_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTeaching.RowCount)
            {
                dtpRegisterDate.Text = dgvTeaching.Rows[e.RowIndex].Cells["RegisterDate"].Value.ToString();
                cbSubject.Text = dgvTeaching.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
            }
        }
    }
}
