using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class QueueElements
    {
        public QueueElements()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(-100);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Dequeue());
            numbers.Enqueue(250);



            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(numbers.First());
            numbers.Clear();
        }
    }
}
