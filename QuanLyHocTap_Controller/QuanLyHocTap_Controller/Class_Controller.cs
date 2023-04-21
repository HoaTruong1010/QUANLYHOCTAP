using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocTap_Data;
using QuanLyHocTap_DTO;

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

        public int AddClass(Class _class)
        {
            if (class_DAO.FindCLass(_class.ClassID))
                return 21;
            if (class_DAO.FindCLassName(_class.ClassName))
                return 24;

            int isValidClass = CheckData.IsValidClass(_class);
            if (isValidClass == 0)
            {
                try
                {
                    class_DAO.AddClass(_class);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return isValidClass;
        }

        public int EditCLass(Class _class)
        {
            if (class_DAO.FindCLassName(_class.ClassID, _class.ClassName))
                return 24;

            int isValidClass = CheckData.IsValidClass(_class);
            if (isValidClass == 0)
            {
                if (class_DAO.FindCLass(_class.ClassID))
                {
                    try
                    {
                        class_DAO.EditClass(_class);
                    }
                    catch (DbUpdateException)
                    {
                        return -2;
                    }
                }
                else
                    return -2;
            }
            return isValidClass;
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
