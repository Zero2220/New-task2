using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public Student(string Fullname,string GroupNo,int Age) 
        {
          this.Fullname = Fullname;
          this.GroupNo = GroupNo;
          this.Age = Age;
        }



        public string Fullname;
        public string GroupNo;
        public int Age;
    }
}
