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
using System.Configuration;

namespace QuanLyHocTap
{
    public partial class GiangVien : Form
    {
        Teacher_Controller teacher_Controller;

        public GiangVien()
        {
            InitializeComponent();
            teacher_Controller = new Teacher_Controller();
        }

        private void ShowTeachers()
        {
            dgvTeacher.DataSource = null;
            teacher_Controller.GetAllTeacher(dgvTeacher);
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            ShowTeachers();
        }
    }
}
