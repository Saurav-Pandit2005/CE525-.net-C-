using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q21
    {
        static void Main(string[] args)
        {
            int n, digit;

            Console.Write("Input the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            digit = Convert.ToInt32(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Series: ");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                sum += term;

                Console.Write(term);
                if (i != n)
                    Console.Write(" + ");
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);

            Console.ReadLine();
        }
    }
}
