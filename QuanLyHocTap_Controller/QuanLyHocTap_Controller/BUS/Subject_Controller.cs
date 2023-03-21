using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTapData.DAO;

namespace QuanLyHocTap_Controller.BUS
{
    public class Subject_Controller
    {
        Subject_DAO subject_Dao;

        public Subject_Controller()
        {
            subject_Dao = new Subject_DAO();
        }

        public void GetSubjects(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = subject_Dao.LoadSubjects();
        }

        public void GetCBBSubjects(ComboBox comboBox)
        {
            comboBox.DataSource = subject_Dao.LoadCBBSubjects();
            comboBox.DisplayMember = "SubjectName";
            comboBox.ValueMember = "SubjectID";
        }

        public bool AddSubject(string subjectId, string subjectName, int credits)
        {
            try
            {
                subject_Dao.AddSubject(subjectId, subjectName, credits);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditSubject(string subjectId, string subjectName, int credits)
        {

            if (subject_Dao.FindSubject(subjectId))
            {
                try
                {
                    subject_Dao.EditSubject(subjectId, subjectName, credits);
                    return true;
                }
                catch (DbUpdateException)
                {
                    return false;
                }
            }
            else
                return false;
        }

        public bool DeleteSubject(string subjectId)
        {

            if (subject_Dao.FindSubject(subjectId))
            {
                try
                {
                    subject_Dao.DeleteSubject(subjectId);
                    return true;
                }
                catch (DbUpdateException)
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
