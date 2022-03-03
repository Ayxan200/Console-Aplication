using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Aplication.Interfaces
{
    internal interface Code_Academy_services
    {
        public List<Group> Groups { get; }
        public string CreatGroup();
        public void EditGroup();
        public void GetAllGroup();
        public void GetAllStudents();
    }
}
