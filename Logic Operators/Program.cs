using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //relational operators
            int a = 21;
            int b = 10;
            if (a == b)
            {
                Console.WriteLine("Line 1 - a is equal to b");
            }
            else
            {
                Console.WriteLine("Line 1 - a is not equal to b");
            }
            if (a < b)
            {
                Console.WriteLine("Line 2 - a is less than b");
            }
            else
            {
                Console.WriteLine("Line 2 - a is not less than b");
            }
            if (a > b)
            {
                Console.WriteLine("Line 3 - a is greater than b");
            }
            else
            {
                Console.WriteLine("Line 3 - a is not greater than b");
            }
            /* Lets change value of a and b */
            a = 5;
            b = 20;
            if (a <= b)
            {
                Console.WriteLine("Line 4 - a is either less than or equal to b");
            }
            if (b >= a)
            {
                Console.WriteLine("Line 5-b is either greater than or equal to b");
            }
            Console.ReadLine;
            Console.Clear;
            //logical operators
            bool a = true;
            bool b = true;
            if (a && b)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }
            /* lets change the value of a and b */
            a = false;
            b = true;
            if (a && b)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is not true");
            }
            if (!(a && b))
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
            Console.ReadLine();
        }
    }
}
