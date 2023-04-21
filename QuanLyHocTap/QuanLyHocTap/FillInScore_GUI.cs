using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap.ultils;
using QuanLyHocTap_Controller;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap
{
    public partial class FillInScore_GUI : Form
    {
        private int selectedTeaching;
        private string selectedStudentID;
        private DateTime registerDate;
        Teaching_Controller teaching_Controller;
        Score_Controller score_Controller;
        Message_Error message_Error;

        public int SelectedTeaching { get => selectedTeaching; set => selectedTeaching = value; }

        public FillInScore_GUI()
        {
            InitializeComponent();
            teaching_Controller = new Teaching_Controller();
            score_Controller = new Score_Controller();
            message_Error = new Message_Error();
        }

        private void Reset()
        {
            nbuMidScore.Value = 0;
            nbuEndPoint.Value = 0;
            dtpInputDate1.Value = dtpInputDate2.Value = DateTime.Now;
            btnSaveScore.Enabled = false;
            gbStudent.Visible = false;
            txtSeachScore.Text = string.Empty;
        }

        private void ShowScores()
        {
            score_Controller.GetScores(dgvScore, selectedTeaching);
            dgvScore.Columns[0].Width = (int)(dgvScore.Width * 0.1);
            dgvScore.Columns[1].Width = (int)(dgvScore.Width * 0.16);
            dgvScore.Columns[2].Width = (int)(dgvScore.Width * 0.16);
            dgvScore.Columns[3].Width = (int)(dgvScore.Width * 0.125);
            dgvScore.Columns[4].Width = (int)(dgvScore.Width * 0.13);
            dgvScore.Columns[5].Width = (int)(dgvScore.Width * 0.125);
            dgvScore.Columns[6].Width = (int)(dgvScore.Width * 0.13);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillInScore_Load(object sender, EventArgs e)
        {
            ShowScores();
            teaching_Controller.GetSubjectByTeachingId(lbSubjectIdText, lbSubjectNameText, selectedTeaching);
            teaching_Controller.GetTeacherByTeachingId(lbTeacherIdText, lbTeacherNameText, selectedTeaching);
            Reset();
        }

        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvScore.Rows.Count)
            {
                gbStudent.Visible = true;
                string registerDateStr = dgvScore.Rows[e.RowIndex].Cells["Registration_Date"].Value.ToString();
                registerDate = DateTime.Parse(registerDateStr);
                selectedStudentID = lbStudentIDText.Text = dgvScore.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                lbStudentNameText.Text = dgvScore.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                dtpInputDate1.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfMidtermScore"].Value.ToString();
                dtpInputDate2.Text = dgvScore.Rows[e.RowIndex].Cells["ModifiedDateOfEndPointScore"].Value.ToString();
                nbuMidScore.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["MidtermScore"].Value.ToString());
                nbuEndPoint.Value = Decimal.Parse(dgvScore.Rows[e.RowIndex].Cells["EndPointScore"].Value.ToString());

                if ((DateTime.Now - registerDate).Days > 175)
                {
                    btnSaveScore.Enabled = false;
                    nbuEndPoint.Enabled = nbuMidScore.Enabled = false;
                }
                else
                {
                    btnSaveScore.Enabled = true;
                    nbuEndPoint.Enabled = nbuMidScore.Enabled = true;
                }
                btnSaveScore.Enabled = true;
            }
            else
                Reset();
        }

        private void FillInScore_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            Decimal midtermScore = nbuMidScore.Value;
            Decimal endPointScore = nbuEndPoint.Value;


            if (selectedStudentID != String.Empty)
            {
                Score score = new Score
                {
                    TeachingID = selectedTeaching,
                    StudentID = selectedStudentID,
                    Registration_Date = registerDate,
                    MidtermScore = midtermScore,
                    ModifiedDateOfMidtermScore = DateTime.Now,
                    EndPointScore = endPointScore,
                    ModifiedDateOfEndPointScore = DateTime.Now
                };
                int result = score_Controller.EditScore(score);
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
                MessageBox.Show("Cập nhật thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
