using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public Student(string name, int rollNo)
        {
            this.Name = name;
            this.RollNo = rollNo;
        }
    }
}
