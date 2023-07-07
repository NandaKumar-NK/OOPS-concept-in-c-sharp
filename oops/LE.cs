using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class LE
    {
        public void  dis() 
        {
            List<int> num = new List<int>() { 7,54,32,15,17,77 };
            List<int> evennum = num.FindAll(x => x%2== 0);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("even numbers:");
            foreach (int i in evennum)
            {
                Console.WriteLine(i);
            }
        }

        public void BankExper()
        {
            List<BankDeatils> accounts= new List<BankDeatils>()
            {
                new BankDeatils(101,"aaa",10000,0),
                new BankDeatils(102,"bbb",20000,1),
                new BankDeatils(103,"ccc",15000,1)
                
            };
            var names = accounts.Select(x => x.Accname);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
