using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class TeachingStaff:College
    {
        private int eid;
        private string name, dept, favsub;
        private double sal;

        public TeachingStaff(string collegename,string address,int pin,int eid, 
            string name, string dept, string favsub, double sal):
            base(collegename,address,pin)
        {
            this.Eid = eid;
            this.Name = name;
            this.Dept = dept;
            this.Favsub = favsub;
            this.Sal = sal;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Sal { get => sal; set => sal = value; }

        public double CalculateSalary(double salary)
        {
            double da = 0.4;
            double hra = 0.2;
            double allowances = salary + (salary * da) + (salary * hra);
            double pf = 0.25;
            double deducations = salary * pf;
            double NetSalary = salary + allowances - deducations;
            return NetSalary;
        }
    }
}
