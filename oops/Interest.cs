using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Interest:BankDeatils
    {
        private double intPercent;

        public Interest(int intPercent,int accno,
         string accname, double balance,
         double interestamt):base(accno, accname, balance, interestamt)
        {
            this.IntPercent = intPercent;
        }

        public double IntPercent { get => intPercent; set => intPercent = value; }

        //public override double CalculateInterest()
        //{

        //    Interestamt = Balance * (intPercent/ 100);
        //    return Interestamt;
                
        //}
    }
}
