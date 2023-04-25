using QuanLyHocTap_Controller;
using QuanLyHocTap.ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap
{
    public partial class Score_GUI : Form
    {
        Teacher_Controller teacher_Controller;
        Score_Controller score_Controller;
        Subject_Controller subject_Controller;
        Teaching_Controller teaching_Controller;
        Student_Controller student_Controller;
        ConvertString convertString;
        Message_Error message_Error;

        private string selectedStudentId;
        private int teachingID = 0;

        public string SelectedStudentId { get => selectedStudentId; set => selectedStudentId = value; }

        public Score_GUI()
        {
            InitializeComponent();
            score_Controller = new Score_Controller();
            subject_Controller = new Subject_Controller();
            teaching_Controller = new Teaching_Controller();
            student_Controller = new Student_Controller();
            teacher_Controller = new Teacher_Controller();
            message_Error = new Message_Error();
            convertString = new ConvertString();
            dgvScore.MultiSelect = true;
            dgvScore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ShowScores()
        {
            dgvScore.DataSource = null;
            score_Controller.GetScores(dgvScore, selectedStudentId);
            dgvScore.Columns[0].Width = (int)(dgvScore.Width * 0.1);
            dgvScore.Columns[1].Width = (int)(dgvScore.Width * 0.16);
            dgvScore.Columns[2].Width = (int)(dgvScore.Width * 0.16);
            dgvScore.Columns[3].Width = (int)(dgvScore.Width * 0.125);
            dgvScore.Columns[4].Width = (int)(dgvScore.Width * 0.13);
            dgvScore.Columns[5].Width = (int)(dgvScore.Width * 0.125);
            dgvScore.Columns[6].Width = (int)(dgvScore.Width * 0.13);
        }

        private void Reset()
        {
            txtSeachScore.Text = string.Empty;
            nbuEndPoint.Value = nbuMidScore.Value = 0;
            dtpInputDate1.Value = dtpInputDate2.Value = dtpRegisterDate.Value = DateTime.Now;
            cbbSubject.SelectedIndex = 0;
            txtSubjectId.Text = cbbSubject.SelectedValue.ToString();
            teaching_Controller.LoadCBBTeacherBySubjectID(cbbTeacher, txtSubjectId.Text, DateTime.Now);

            cbbSubject.Enabled = btAddScore.Enabled = cbbTeacher.Enabled = true;
            btnDeleteScore.Enabled = false;
        }

        private void KetQuaHocTap_Load(object sender, EventArgs e)
        {
            student_Controller.GetStudent(txtStudentId, txtStudentName, selectedStudentId);
            ShowScores();
            subject_Controller.GetCBBSubjects(cbbSubject);

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
                teachingID = (int)dgvScore.Rows[e.RowIndex].Cells["TeachingID"].Value;
                teaching_Controller.GetSubjectByTeachingId(txtSubjectId, cbbSubject, teachingID);
                teacher_Controller.GetCBBTeachers(cbbTeacher);
                teaching_Controller.GetTeacherByTeachingId(txtTeacherId, cbbTeacher, teachingID);
                dtpRegisterDate.Text = dgvScore.Rows[e.RowIndex].Cells["Registration_Date"].Value.ToString();
                dtpInputDate1.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfMidtermScore"].Value.ToString();
                dtpInputDate2.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfEndPointScore"].Value.ToString();
                nbuMidScore.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["MidtermScore"].Value.ToString());
                nbuEndPoint.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["EndPointScore"].Value.ToString());

                if ((DateTime.Now - dtpRegisterDate.Value).Days > 10)
                    btnDeleteScore.Enabled = false;
                else
                    btnDeleteScore.Enabled = true;
                btAddScore.Enabled = cbbSubject.Enabled = cbbTeacher.Enabled = false;
            }
            else
                Reset();
        }

        private void btAddScore_Click(object sender, EventArgs e)
        {
            string subjectID = convertString.DeleteSpacing(txtSubjectId.Text);
            string teacherID = convertString.DeleteSpacing(txtTeacherId.Text);
            Decimal midtermScore = nbuMidScore.Value;
            Decimal endPointScore = nbuEndPoint.Value;
            int result;

            int id = teaching_Controller.GetTeaching(subjectID, teacherID);
            if (id > 0)
            {
                Score score = new Score
                {
                    TeachingID = id,
                    StudentID = selectedStudentId,
                    Registration_Date = DateTime.Now,
                    MidtermScore = midtermScore,    
                    ModifiedDateOfMidtermScore = DateTime.Now,
                    EndPointScore = endPointScore,
                    ModifiedDateOfEndPointScore = DateTime.Now
                    
                };
                result = score_Controller.AddScore(score);
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
            if (MessageBox.Show(message_Error.GetMessage(38), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                DateTime registerDate = dtpRegisterDate.Value;

                if (teachingID > 0 && score_Controller.DeleteScore(teachingID, selectedStudentId, registerDate))
                {
                    MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowScores();
                    Reset();
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnCalcScholarship_Click(object sender, EventArgs e)
        {
            int selectedCount = dgvScore.SelectedRows.Count;
            foreach(DataGridViewRow row in dgvScore.SelectedRows) 
            {
                Console.WriteLine(row.ToString());
            }
            double midTerm, endPoint;
            double result = 0;

            if(selectedCount <= 1)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 2 môn học để xét!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < selectedCount; i++)
                {
                    midTerm = double.Parse(dgvScore.SelectedRows[i].Cells["MidtermScore"].Value.ToString());
                    endPoint = double.Parse(dgvScore.SelectedRows[i].Cells["EndPointScore"].Value.ToString());
                    result += midTerm * 0.4 + endPoint * 0.6;
                }
                result /= selectedCount;

                if (result < 4)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) +"\nXếp loại học bổng: Kém!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result < 5)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Yếu!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result < 5.5)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Trung bình yếu!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result < 6.5)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Trung bình!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result < 7)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Trung bình khá!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result < 8)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Khá!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (result < 8.5)
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Khá giỏi!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Điểm trung bình: " + Math.Round(result, 2) + "\nXếp loại học bổng: Giỏi!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    

        }

        private void btnSearchScore_Click(object sender, EventArgs e)
        {
            string kw = convertString.DeleteSpacing(txtSeachScore.Text);

            int result = score_Controller.SearchTeaching(dgvScore, kw, selectedStudentId);

            if (result != 0)
            {
                MessageBox.Show(message_Error.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowScores();
                Reset();
            }
        }
    }
}
