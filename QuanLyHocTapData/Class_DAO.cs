﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocTap_DTO;

namespace QuanLyHocTap_Data
{
    public class Class_DAO
    {
        QuanLyHocTapEntities db;

        public Class_DAO()
        {
            db = new QuanLyHocTapEntities();
        }

        public dynamic LoadClasses()
        {
            var listClass = db.Classes.Select(c => new
                {
                    c.ClassID,
                    c.ClassName,
                    c.TotalStudent,
                    c.TeacherID,
                    c.Teacher.TeacherName,
                }).ToList();
            return listClass;
        }

        public dynamic LoadCBBClasses()
        {
            var listClass = db.Classes.Select(s => new
            {
                s.ClassID,
                s.ClassName
            }).ToList();
            return listClass;
        }
        public void AddClass(Class _class)
        {
            db.Classes.Add(_class);
            db.SaveChanges();
        }

        public dynamic SearchClass(string kw)
        {
            var classes = db.Classes.Where(c => c.ClassID.ToLower().Contains(kw.ToLower()) || c.ClassName.ToLower().Contains(kw.ToLower())).Select(c => new
            {
                c.ClassID,
                c.ClassName,
                c.TotalStudent,
                c.TeacherID,
                c.Teacher.TeacherName,
            }).ToList();
            return classes;
        }

        public bool FindCLassName(string className)
        {
            var cl = db.Classes.Where(s => s.ClassName.ToLower() == className.ToLower()).Select(s => s.ClassName).ToList();
            if (cl.Count > 0)
                return true;
            else
                return false;
        }

        public bool FindCLassName(string classID, string className)
        {
            var cl = db.Classes.Where(s => s.ClassName.ToLower() == className.ToLower()).Select(s => s.ClassID).ToList();
            if (cl.Count > 0)
            {
                foreach (var c in cl)
                    if (c.ToString() == classID)
                        return false;
                return true;
            }
            else
                return false;
        }

        public bool FindCLass(string classId)
        {
            Class cl = db.Classes.Find(classId);
            if (cl != null)
                return true;
            else
                return false;
        }

        public void EditClass(Class _class)
        {
            Class cl = db.Classes.Find(_class.ClassID);
            cl.ClassName = _class.ClassName;
            cl.TotalStudent = _class.TotalStudent;
            cl.TeacherID = _class.TeacherID;

            db.SaveChanges();
        }

        public void DeleteClass(string classId)
        {
            Class cl = db.Classes.Find(classId);
            List<Student> students = db.Students.Where(s => s.ClassID == classId).Select(s => s).ToList();

            foreach (Student student in students)
                student.ClassID = null;


            db.Classes.Remove(cl);
            db.SaveChanges();
        }
    }
}
