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
            comboBox.DataSource = class_DAO.LoadCBBClasses();
            comboBox.DisplayMember = "ClassName";
            comboBox.ValueMember = "ClassID";
        }

        public bool AddClass(string classId, string className,
            int total, string teacherId)
        {
            try
            {
                class_DAO.AddClass(classId, className, total, teacherId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCLass(string classId, string className,
            int total, string teacherId)
        {

            if (class_DAO.FindCLass(classId))
            {
                try
                {
                    class_DAO.EditClass(classId, className, total, teacherId);
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
    }
}
