using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q14
    {
        static void Main()
        {
            Console.Write("Input the marks obtained in Maths: ");
            int maths = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = int.Parse(Console.ReadLine());

            int total = maths + physics + chemistry;
            int mpTotal = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                (total >= 180 || mpTotal >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
