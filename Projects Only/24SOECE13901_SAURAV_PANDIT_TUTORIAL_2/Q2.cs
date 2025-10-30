using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;

            /* check the boolean condition */
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            else
            {
                /* if condition is false then print the following */
                Console.WriteLine("a is not less than 20");   // Missing statement-1
            }

            Console.WriteLine("value of a is : {0}", a);      // Missing statement-2

            Console.ReadLine();
        } 
    }
}
