using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class BankAccount

    {
        private int custid;
        private string name;
        private long accno;
        private double balance;
        private string status;

        public BankAccount(int custid, string name, long accno, double balance, string status)
        {
            this.Custid = custid;
            this.Name = name;
            this.Accno = accno;
            this.Balance = balance;
            this.Status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Name { get => name; set => name = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }

        public void Checkaccstatus( long accno)
        {
            if(accno == Accno)
            {
                accno = Accno; 
                status=Status;
                name= Name;
                balance=Balance;

            }


        }
        public void Checkaccstatus(int custid)
        {
            if (custid == Custid)
            {
                accno = Accno;
                status = Status;
                name = Name;
                balance = Balance;

            }


        }
    }
}
