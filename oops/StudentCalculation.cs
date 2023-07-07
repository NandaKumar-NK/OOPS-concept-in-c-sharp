using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class StudentCalculation:StudentMarks
    {
        private double tot, avg;
        public StudentCalculation(int rollno, string name, double mark1, double mark2, double mark3, double tot, double avg):base(rollno, name,mark1,mark2,mark3) 
        {
            this.Tot = tot;
            this.Avg = avg;
        }

        public double Tot { get => tot; set => tot = value; }
        public double Avg { get => avg; set => avg = value; }

        public void Calculate()
        {
            this.Tot = this.Mark1 + this.Mark2 + this.Mark3;
            this.Avg = this.Tot / 3;
        }
    }
}
