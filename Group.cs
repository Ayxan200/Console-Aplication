using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Aplication
{
     class Group
    {
        public static int count = 1;
        public string No;
        public bool IsOnline;
        public int Limit;
        public string Students;
        public Categories Category;
        public Group(string fullname, string groupNo, Categories category)
        {
            switch (Category)
            {
                case Categories.Programing:
                 No = $"P{count}";
                    break;
                case Categories.Sysem_Adminstration:
                 No =  $"S{count}";
                    break;
                case Categories.Design:
                No=  $"D{count}";
                    break;
                default:
                    break;
            }

            Category = category;
            count++;   
        }
        
     }
}
