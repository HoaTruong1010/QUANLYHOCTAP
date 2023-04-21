using QuanLyHocTap_Data;
using QuanLyHocTap_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public static int IsValidSubject(Subject subject)
        {
            if (subject != null)
            {
                if (subject.SubjectID == null || subject.SubjectID.Length < 6)
                    return 13;
                if (subject.SubjectID.Length > 6)
                    return 14;
                if (subject.SubjectName == string.Empty)
                    return 16;
                if (subject.SubjectName.Length > 25)
                    return 17;
                return 0;
            }
            return -4;
        }

        public static int IsValidClass(Class _class)
        {
            if (_class != null)
            {
                if (_class.ClassID == String.Empty || _class.ClassID.Length < 8)
                    return 19;
                if (_class.ClassID.Length > 8)
                    return 20;
                if (_class.ClassName == String.Empty)
                    return 22;
                if (_class.ClassName.Length > 20)
                    return 23;
                return 0;
            }
            return -4;
        }

        public static int IsValidStudent(Student student)
        {
            if (student != null)
            {
                TimeSpan timeDifference = DateTime.Now - student.DayOfBirth;
                double age = timeDifference.TotalDays / 365.2425;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

                if (student.StudentID.Length < 10)
                    return 25;
                if (student.StudentID.Length > 10)
                    return 26;
                if (student.StudentName.Length == 0)
                    return 30;
                if (student.StudentName.Length > 27)
                    return 31;
                if (age < 17)
                    return 28;
                if (student.ID.Length != 9 && student.ID.Length != 12)
                    return 6;
                if (!regex.IsMatch(student.Email))
                    return 7;
                if (student.Phone.Length != 10)
                    return 11;
                if (student.StudentAddress.Length == 0)
                    return 8;
                if (student.StudentAddress.Length > 100)
                    return 9;
                return 0;
            }
            return -6;
        }

        public static int IsValidScore(Score score)
        {
            if (score != null)
            {
                if (score.MidtermScore > 10 || score.EndPointScore > 10)
                    return 33;
                if (score.EndPointScore < 0 || score.MidtermScore < 0)
                    return 34;
                return 0;
            }
            return -7;
            
        }
    }
}
