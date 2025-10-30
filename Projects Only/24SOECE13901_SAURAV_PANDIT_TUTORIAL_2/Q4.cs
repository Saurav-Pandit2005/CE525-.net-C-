using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== Arithmetic Operators ===");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + ((double)A / B));

            Console.WriteLine("\n=== Relational Operators ===");
            Console.WriteLine("A > B : " + (A > B));
            Console.WriteLine("A == B : " + (A == B));

            Console.WriteLine("\n=== Logical Operator ===");
            Console.WriteLine("A>0 && B>0 : " + (A > 0 && B > 0));

            Console.WriteLine("\n=== Bitwise Operator ===");
            Console.WriteLine("A & B = " + (A & B));

            Console.WriteLine("\n=== Other Data Types ===");
            double d = (double)A / B;
            Console.WriteLine("Double division: " + d);

            string str = "Numbers: " + A + " and " + B;
            Console.WriteLine("String example: " + str);

            bool flag = (A == B);
            Console.WriteLine("Boolean example (A==B): " + flag);

            Console.ReadLine();
        }
    }
}
