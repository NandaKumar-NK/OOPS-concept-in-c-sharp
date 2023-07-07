using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class addition
    {
        private int num1, num2;
        public addition()
        {
            bonus =6;
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        private static int bonus;
        internal static  void  add(int x,int y,out int n1,out int n2)
        {

           
            n1=bonus+x;
            n2=bonus+y;

            
        
        }
    }

}
