using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_1
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            string name, toggleName = "";

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            foreach (char ch in name)
            {
                if (char.IsUpper(ch))
                    toggleName += char.ToLower(ch);
                else if (char.IsLower(ch))
                    toggleName += char.ToUpper(ch);
                else
                    toggleName += ch; // For spaces or symbols
            }

            Console.WriteLine("Output: " + toggleName);

            Console.ReadLine();
        }
    }
}
