using QuanLyHocTap_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocTap_Controller
{
    public class CheckData
    {
        public static int IsValidTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                if (teacher.TeacherID.Length == 0 || teacher.TeacherID.Length < 8)
                {
                    return 1;
                }
                if (teacher.TeacherID.Length > 8)
                {
                    return 2;
                }
                if (teacher.TeacherName.Length == 0)
                {
                    return 3;
                }
                if (teacher.TeacherName.Length > 27)
                {
                    return 4;
                }

                TimeSpan timeDifference = DateTime.Now - teacher.DayOfBirth;
                double age = timeDifference.TotalDays / 365.2425;
                if (age < 18)
                {
                    return 5;
                }

                if (teacher.ID.Length != 9 && teacher.ID.Length != 12)
                {
                    return 6;
                }

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
                if (!regex.IsMatch(teacher.Email))
                {
                    return 7;
                }

                if (teacher.Phone.Length != 10)
                {
                    return 11;
                }

                if (teacher.TeacherAddress.Length == 0)
                {
                    return 8;
                }

                if (teacher.TeacherAddress.Length > 100)
                {
                    return 9;
                }

                return 0;
            }
            return -3;
        }
    }
}
