using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Intersample : AddCon
    {
        public int intadd(int num1, int num2)
        {

            return num1+num2;  
        }

        public string strconcat(string n1,string n2)
        {
           return n1+ n2;
        }
    }
}
