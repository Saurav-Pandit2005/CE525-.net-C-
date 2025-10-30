using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q15
    {
        static void Main(string[] args)
        {
            int number, originalNumber, remainder, result = 0, digits = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            originalNumber = number;

            int temp = number;
            while (temp != 0)
            {
                temp /= 10;
                digits++;
            }

            temp = number;
            while (temp != 0)
            {
                remainder = temp % 10;
                result += (int)Math.Pow(remainder, digits);
                temp /= 10;
            }

            if (result == originalNumber)
                Console.WriteLine(originalNumber + " is an Armstrong number.");
            else
                Console.WriteLine(originalNumber + " is not an Armstrong number.");

            Console.ReadLine();
        }
    }
}
