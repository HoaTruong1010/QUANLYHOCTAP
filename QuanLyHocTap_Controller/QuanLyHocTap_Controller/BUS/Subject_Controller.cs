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

        public int SearchTeacher(DataGridView dataGrirdView, string kw)
        {
            dataGrirdView.DataSource = subject_Dao.SearchSubject(kw);
            if (dataGrirdView.RowCount > 0)
                return 0;
            return 10;

        }

        public void GetCBBSubjects(ComboBox comboBox)
        {
            comboBox.DataSource = subject_Dao.LoadCBBSubjects();
            comboBox.DisplayMember = "SubjectName";
            comboBox.ValueMember = "SubjectID";
        }

        public int AddSubject(string subjectId, string subjectName, double credits)
        {
            if (subjectId == null || subjectId.Length < 6)
                return 13;
            if (subjectId.Length > 6)
                return 14;
            if (subject_Dao.FindSubject(subjectId))
                return 15;
            if (subjectName == string.Empty)
                return 16;
            if (subjectName.Length > 25)
                return 17;
            if(subject_Dao.FindSubjectName(subjectName))
                return 18;

            try
            {
                subject_Dao.AddSubject(subjectId, subjectName, credits);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int EditSubject(string subjectId, string subjectName, double credits)
        {
            if (subjectId == null || subjectId.Length < 6)
                return 13;
            if (subjectId.Length > 6)
                return 14;
            if (subjectName == string.Empty)
                return 16;
            if (subjectName.Length > 25)
                return 17;
            if (subject_Dao.FindSubjectName(subjectId, subjectName))
                return 18;

            if (subject_Dao.FindSubject(subjectId))
            {
                try
                {
                    subject_Dao.EditSubject(subjectId, subjectName, credits);
                    return 0;
                }
                catch (DbUpdateException)
                {
                    return -2;
                }
            }
            else
                return -2;
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
