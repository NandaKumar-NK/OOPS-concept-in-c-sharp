using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
     internal  class BankDeatils
    {
       private int accno;
       private string accname;
       private double balance;
       private double interestamt;
        
        public  BankDeatils(int accno,string accname, double balance,double interestamt )
        {
            this.Accno = accno;
            this.Accname = accname; 
            this.Balance = balance;
            this.Interestamt = interestamt;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interestamt { get => interestamt; set => interestamt = value; }

        //public abstract double CalculateInterest();
       
    }
}
