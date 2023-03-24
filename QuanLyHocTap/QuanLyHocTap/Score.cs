using QuanLyHocTap_Controller.BUS;
using QuanLyHocTapData.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocTap
{
    public partial class Score : Form
    {
        Score_Controller score_Controller;
        Subject_Controller subject_Controller;
        Teaching_Controller teaching_Controller;
        Student_Controller student_Controller;
        Teacher_Controller teacher_Controller;
        Message_Error message_Error;

        private string selectedStudentId;

        public string SelectedStudentId { get => selectedStudentId; set => selectedStudentId = value; }

        public Score()
        {
            InitializeComponent();
            score_Controller = new Score_Controller();
            subject_Controller = new Subject_Controller();
            teaching_Controller = new Teaching_Controller();
            student_Controller = new Student_Controller();
            teacher_Controller = new Teacher_Controller();
            message_Error = new Message_Error();
        }

        private void ShowScores()
        {
            dgvScore.DataSource = null;
            score_Controller.GetScores(dgvScore, selectedStudentId);
        }

        private void Reset()
        {
            txtSeachScore.Text = string.Empty;
            nbuEndPoint.Value = nbuMidScore.Value = 0;
            dtpInputDate1.Value = dtpInputDate2.Value = dtpRegisterDate.Value = DateTime.Now;
            cbbSubject.SelectedIndex = 0;

            cbbSubject.Enabled = cbbTeacher.Enabled = true;
            btnDeleteScore.Enabled = btnSaveScore.Enabled = false;
        }

        private void KetQuaHocTap_Load(object sender, EventArgs e)
        {
            student_Controller.GetStudent(txtStudentId, txtStudentName, selectedStudentId);
            ShowScores();
            subject_Controller.GetCBBSubjects(cbbSubject);
            txtSubjectId.Text = cbbSubject.SelectedValue.ToString();
            teaching_Controller.LoadCBBTeacherBySubjectID(cbbTeacher, txtSubjectId.Text, DateTime.Now);

            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvScore.Rows.Count)
            {
                teaching_Controller.GetSubjectByTeachingId(txtSubjectId, cbbSubject, (int)dgvScore.Rows[e.RowIndex].Cells["TeachingID"].Value);
                teaching_Controller.GetTeacherByTeachingId(txtTeacherId, cbbTeacher, (int)dgvScore.Rows[e.RowIndex].Cells["TeachingID"].Value);
                dtpRegisterDate.Text = dgvScore.Rows[e.RowIndex].Cells["Registration_Date"].Value.ToString();
                dtpInputDate1.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfMidtermScore"].Value.ToString();
                dtpInputDate2.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfEndPointScore"].Value.ToString();
                nbuMidScore.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["MidtermScore"].Value.ToString());
                nbuEndPoint.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["EndPointScore"].Value.ToString());

                if ((DateTime.Now - dtpRegisterDate.Value).Days > 10) 
                    btnDeleteScore.Enabled = false;
                else
                    btnDeleteScore.Enabled= true;
                if ((DateTime.Now - dtpRegisterDate.Value).Days > 100)
                    btnSaveScore.Enabled = false;
                else
                    btnSaveScore.Enabled= true;
                btAddScore.Enabled = cbbSubject.Enabled = cbbTeacher.Enabled = false;
            }
            else
                Reset();
        }

        private void btAddScore_Click(object sender, EventArgs e)
        {
            string subjectID = txtSubjectId.Text;
            string teacherID = txtTeacherId.Text;
            Decimal midtermScore = nbuMidScore.Value;
            Decimal endPointScore = nbuEndPoint.Value;
            int result;

            int id = teaching_Controller.GetTeaching(subjectID, teacherID);
            if (id > 0)
            {
                result = score_Controller.AddScore(id, selectedStudentId, DateTime.Now, midtermScore, DateTime.Now, endPointScore, DateTime.Now);
                if(result == 0)
                {
                    MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowScores();
                    Reset();
                }
                else
                    MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteScore_Click(object sender, EventArgs e)
        {
            string subjectID = txtSubjectId.Text;
            string teacherID = txtTeacherId.Text;
            DateTime registerDate = dtpRegisterDate.Value;

            int id = teaching_Controller.GetTeaching(subjectID, teacherID);
            if (id > 0 && score_Controller.DeleteScore(id, selectedStudentId, registerDate))
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowScores();
                Reset();
            }
            else
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            string subjectID = txtSubjectId.Text;
            string teacherID = txtTeacherId.Text;
            DateTime registerDate = dtpRegisterDate.Value;
            Decimal midtermScore = nbuMidScore.Value;
            Decimal endPointScore = nbuEndPoint.Value;

            int id = teaching_Controller.GetTeaching(subjectID, teacherID);
            if (id > 0)
            {
                int result = score_Controller.EditScore(id, selectedStudentId, registerDate, midtermScore, DateTime.Now, endPointScore, DateTime.Now);
                if (result == 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowScores();
                    Reset();
                }
                else
                    MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSubjectId.Text = cbbSubject.SelectedValue.ToString();
            teaching_Controller.LoadCBBTeacherBySubjectID(cbbTeacher, txtSubjectId.Text, DateTime.Now);
        }

        private void cbbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTeacherId.Text = cbbTeacher.SelectedValue.ToString();
        }

        private void Score_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
