using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q11
    {
        static void Main(string[] args)
        {
            string name;
            char gender;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your gender (M/F): ");
            gender = Convert.ToChar(Console.ReadLine().ToUpper());

            if (gender == 'M')
            {
                Console.WriteLine("Output: Mr. " + name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Output: Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender input. Please enter M or F.");
            }

            Console.ReadLine();
        }
    }
}
