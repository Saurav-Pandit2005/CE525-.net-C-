using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q8
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            string upperName = name.ToUpper();

            Console.WriteLine("Output: " + upperName);

            Console.ReadLine();
        }
    }
}
