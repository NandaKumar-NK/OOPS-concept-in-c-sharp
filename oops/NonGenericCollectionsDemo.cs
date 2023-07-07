using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class NonGenericCollectionsDemo
    {
        
        public void ArrayListElements()
        {
                ArrayList numbers= new ArrayList();
            numbers.Add(1);
            numbers.Add("20");
            numbers.Add(30);
         
            numbers.Remove(numbers.IndexOf(0));
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            
             

        }
        public void  StackElements()
        {
            Stack numbers = new Stack();
            numbers.Push(100);
            numbers.Push(200);
            numbers.Push(-100);
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Pop());
            numbers.Push(250);



            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Clear();
        }
        public void QueueElements()
        {
            Queue numbers = new Queue();
            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(-100);
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Dequeue());
            numbers.Enqueue(250);



            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(numbers.First());
            numbers.Clear();
        }
        public  void SortedListElements()
        {
            SortedList Students = new SortedList();
            Students.Add(12, "abi");
            Students.Add(32, "bala");
            Students.Add(3, "chan");

            foreach (var num in Students.Keys)
            {
                Console.WriteLine(num + ":" + Students[num]);
            }
        }
        public void hashListElements()
        {
            SortedList Students = new SortedList();
            Students.Add(12, "abi");
            Students.Add(32, "bala");
            Students.Add(3, "chan");

            foreach (var num in Students.Keys)
            {
                Console.WriteLine(num + ":" + Students[num]);
            }
        }


    }
}
