﻿using System;
using System.Collections.Generic;
using System.Text;
using Console_Aplication.Interfaces;

namespace Console_Aplication.services
{
    class Code_services : Iacademyservices
    {
        private List<Group> _groups = new List<Group>();
        private object groupNo;

        public List<Group> Groups => _groups;

        public string CreatGroup(string fullname, string groupNo, Categories category)
        {
            if (fullname != fullname || groupNo != groupNo)
            {
                return "Please chose valid fullname or groupNo value";
            }
            Group group = new Group(fullname, groupNo, category);

            _groups.Add(group);
            return group.No;
        }

        public void CreatStudents(string No, string fullname)
        {
            Group group = FindGroup(No);
            Student student = new Student(fullname,group.No);
            group.Students.Add(student);

        }

        public void EditGroup(string No, string newNo, Group group)
        {
            Group existedgroup = null;
            foreach (Group item in _groups)
            {
                if (group.No.ToLower().Trim() == newNo.ToLower().Trim()) ;
                {
                    existedgroup = group;
                }
            }
            if (existedgroup == null)
            {
                Console.WriteLine("Please choose correct Group No");
                return;
            }

            foreach (Group group1 in _groups)
            {
                if (group.No.ToLower().Trim() == newNo.ToLower().Trim()) ;
                {
                    Console.WriteLine(existedgroup = group);
                    return;
                }
            }
            existedgroup.No = newNo.ToUpper();
        }
        public Group FindGroup(string newNo)
        {
            Group group;
            foreach (Group item in _groups)
            {
                if (item.No.ToLower().Trim() == newNo.ToLower().Trim()) ;
                { group = item;
                    return group;
                }
            }
            return null;
        }

        public void GetAllGroup()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no Group in the Academy");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void GetAllStudents()
        {


        }

        public void StudentGroupListShow(string No)
        {
            Group group = FindGroup(No);
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }

        }
    }
}