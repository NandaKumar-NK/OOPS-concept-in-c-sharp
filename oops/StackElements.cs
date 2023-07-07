using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class StackElements
    {
        public StackElements()
        { 
            Stack<int > numbers= new Stack<int>();   
            numbers.Push(100);
            numbers.Push(200);
            numbers.Push(-100);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Pop());
            numbers.Push(250);
           
           
            
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Clear();
        }

       
    }

}
