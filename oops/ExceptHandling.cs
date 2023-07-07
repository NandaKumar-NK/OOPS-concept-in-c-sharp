using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class ExceptHandling
    {
         int n1, n2, ans;

        public ExceptHandling(int n1, int n2,int ans)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.ans = ans;
            
        }
        public int add()
        {
            this.ans=this.n1+this.n2;
            return this.ans;
        }
        public int  mult()
        {
            this.ans = this.n1 * this.n2;
            return this.ans;
        }
        public int div()
        {
            int[] num = { 10, 10 };
            try
            {
                this.ans = this.n1 / this.n2;
                int x = num[0] / num[3];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Dont give 0 in the document");

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {

                Console.WriteLine("done");
            }
            return this.ans;
        }
        public void CheckVal(int val)
        {
            if (val < 0)
            {
                throw new ArgumentException("don't pass zero");
            }
            else if (val < 18)
            {
                throw new ArithmeticException("Value should be grater than 18");
            }
           else {
                Console.WriteLine("ok");
            }
        }
    }
}
