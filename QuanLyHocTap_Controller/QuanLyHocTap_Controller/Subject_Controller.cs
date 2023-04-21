using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QuanLyHocTap_Data;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Controller
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

        public int AddSubject(Subject subject)
        {
            if (subject_Dao.FindSubject(subject.SubjectID))
                return 15;
            if(subject_Dao.FindSubjectName(subject.SubjectName))
                return 18;

            int isValidSubject = CheckData.IsValidSubject(subject);
            if(isValidSubject == 0)
            {
                try
                {
                    subject_Dao.AddSubject(subject);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return isValidSubject;
        }

        public int EditSubject(Subject subject)
        {            
            if (subject_Dao.FindSubjectName(subject.SubjectID, subject.SubjectName))
                return 18;

            int isValidSubject = CheckData.IsValidSubject(subject);
            if (isValidSubject == 0)
            {
                if (subject_Dao.FindSubject(subject.SubjectID))
                {
                    try
                    {
                        subject_Dao.EditSubject(subject);
                    }
                    catch (DbUpdateException)
                    {
                        return -2;
                    }
                }
                else
                    return -2;
            }
            return isValidSubject;
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
