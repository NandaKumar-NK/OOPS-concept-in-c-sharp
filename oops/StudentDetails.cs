using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class StudentDetails
    {
        private int rollno;
        private string name;
        

        public StudentDetails(int rollno, string name)
        {
            this.Rollno = rollno;
            this.Name = name;
            
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
       

       
    }
   
}
