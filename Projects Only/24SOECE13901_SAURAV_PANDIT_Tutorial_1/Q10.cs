using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            string mobile;

            Console.Write("Enter your mobile number: ");
            mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("Output: " + masked);
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Must be at least 5 digits.");
            }

            Console.ReadLine();
        }
    }
}
