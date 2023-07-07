using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class AdminStaff:College
    {
        private int eid;
        private string name;
        private double sal;
        public AdminStaff(string collegename,string address,int pin,int eid,
            string name, double sal)
            : base(collegename, address, pin)
        {
            this.Eid = eid; 
            this.Name = name;   
            this.Sal = sal;

        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public double Sal { get => sal; set => sal = value; }

        public double CalculateSalary(double salary)
        {
            double da = 0.3;
            double hra = 0.15;
            double allowances = salary + (salary * da) + (salary * hra);
            double pf = 0.20;
            double deducations = salary * pf;
            double NetSalary = salary + allowances - deducations;
            return NetSalary;
        }
    }
}
