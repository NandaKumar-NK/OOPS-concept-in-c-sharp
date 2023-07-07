using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class HashElements
    {
        public void SortedListElements()
        {
            SortedList<int, string> Students = new SortedList<int, string>();
            Students.Add(12, "abi");
            Students.Add(32, "bala");
            Students.Add(3, "chan");

            foreach (int num in Students.Keys)
            {
                Console.WriteLine(num + ":" + Students[num]);
            }
        }

        //foreach (string val in Students.Values)
        //{
        //    Console.WriteLine(val);
        //}
        //Console.WriteLine(Students[2]);

    }
}

