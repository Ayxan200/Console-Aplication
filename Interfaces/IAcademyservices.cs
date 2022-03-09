using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Aplication.Interfaces
{
    interface Iacademyservices
    {
        public List<Group> Groups { get; }
        public string CreatGroup(string fullname, string groupNo, Categories category);
        public void EditGroup(string No, string newNo, Group group);
        public void GetAllGroup();
        public void GetAllStudents();
        public void CreatStudents();
        public void StudentGroupListShow();

    }
}
