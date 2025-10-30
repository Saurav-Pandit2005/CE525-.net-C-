using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q13
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");

            while (true)
            {
                c = a + b;
                if (c > 55)
                    break;

                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
