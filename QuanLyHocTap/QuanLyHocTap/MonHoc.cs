using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Controller.BUS;

namespace QuanLyHocTap
{
    public partial class MonHoc : Form
    {
        private Subject_Controller controller;
        public MonHoc()
        {
            InitializeComponent();
            controller = new Subject_Controller();
        }

        private void ShowSubjects()
        {
            dgvSubject.DataSource = null;
            controller.GetSubjects(dgvSubject);
        }


        private void MonHoc_Load(object sender, EventArgs e)
        {
            ShowSubjects();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSubject.RowCount)
            {
                txtSubjectID.Text = dgvSubject.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString();
                txtSubjectName.Text = dgvSubject.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                nbuSubjectCredit.Value = Int32.Parse(dgvSubject.Rows[e.RowIndex].Cells["Credits"].Value.ToString());
            }
        }
    }
}
