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
    public partial class KetQuaHocTap : Form
    {
        Score_Controller getController;
        Subject_Controller subc;
        Teacher_Controller tc;
        Student_Controller student;

        public KetQuaHocTap()
        {
            InitializeComponent();
            getController = new Score_Controller();
            subc = new Subject_Controller();
            tc = new Teacher_Controller();
            student = new Student_Controller();
        }

        private void ShowScores()
        {
            dgvScore.DataSource = null;
            getController.GetScores(dgvScore);
        }

        private void KetQuaHocTap_Load(object sender, EventArgs e)
        {
            ShowScores();
            student.GetCBBStudents(cbbStudent);
            subc.GetCBBSubjects(cbbSubject);
            tc.GetCBBTeachers(cbbTeacher);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvScore.Rows.Count)
            {
                cbbStudent.Text = dgvScore.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                cbbSubject.Text = dgvScore.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                cbbTeacher.Text = dgvScore.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();
                dtpRegisterDate.Text = dgvScore.Rows[e.RowIndex].Cells["Registration_Date"].Value.ToString();
                dtpInputDate1.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfMidtermScore"].Value.ToString();
                dtpInputDate2.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfEndPointScore"].Value.ToString();
                nbuMidScore.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["MidtermScore"].Value.ToString());
                nbuEndPoint.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["EndPointScore"].Value.ToString());
            }
        }
    }
}
