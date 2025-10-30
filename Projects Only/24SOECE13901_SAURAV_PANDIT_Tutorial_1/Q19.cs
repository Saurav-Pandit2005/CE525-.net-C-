using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q19
    {
        static void Main(string[] args)
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
