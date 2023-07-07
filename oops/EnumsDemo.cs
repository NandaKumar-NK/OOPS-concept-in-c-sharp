using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class EnumsDemo
    {
        enum Colors
        {
            red, green, blue

        }
        public void display()
        {

            Colors color1= Colors.red;
            Colors color2 = Colors.green;
            Colors color3 = Colors.blue;
            // Console.WriteLine(color1+"  "+color2+"  "+color3);

            Console.WriteLine(Colors.blue);
        }
    }
}
