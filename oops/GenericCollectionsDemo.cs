using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class GenericCollectionsDemo
    {

        public void ListElements()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Append(50);
            numbers.Remove(numbers.IndexOf(0));
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            for (int i=0;i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);   
            }

        }
    }
}
