using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Data;


namespace QuanLyHocTap_Controller
{
    public class Class_Controller
    {
        Class_DAO class_DAO;

        public Class_Controller() 
        {
            class_DAO = new Class_DAO();
        }

        public void GetClasses(DataGridView dataGrirdView)
        {
            dataGrirdView.DataSource = class_DAO.LoadClasses();
        }

        public void GetCBBClasses(ComboBox comboBox)
        {
            comboBox.Items.Add(" ");
            comboBox.DataSource = class_DAO.LoadCBBClasses();
            comboBox.DisplayMember = "ClassName";
            comboBox.ValueMember = "ClassID";
        }

        public int AddClass(string classId, string className,
            int total, string teacherId)
        {
            if (classId == String.Empty || classId.Length < 8)
                return 19;
            if (classId.Length > 8)
                return 20;
            if (class_DAO.FindCLass(classId))
                return 21;
            if (className == String.Empty)
                return 22;
            if (className.Length > 20)
                return 23;
            if (class_DAO.FindCLassName(className))
                return 24;

            try
            {
                class_DAO.AddClass(classId, className, total, teacherId);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int EditCLass(string classId, string className,
            int total, string teacherId)
        {
            if (className == String.Empty)
                return 22;
            if (className.Length > 20)
                return 23;
            if (class_DAO.FindCLassName(classId, className))
                return 24;

            if (class_DAO.FindCLass(classId))
            {
                try
                {
                    class_DAO.EditClass(classId, className, total, teacherId);
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

        public bool DeleteCLass(string classId)
        {

            if (class_DAO.FindCLass(classId))
            {
                try
                {
                    class_DAO.DeleteClass(classId);
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

        public int SearchClass(DataGridView dataGridView, string kw)
        {
            dataGridView.DataSource = class_DAO.SearchClass(kw);
            if (dataGridView.Rows.Count > 0)
                return 0;
            return 10;
        }
    }
}
