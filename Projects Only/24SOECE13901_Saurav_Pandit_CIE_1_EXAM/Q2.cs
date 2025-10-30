using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_Saurav_Pandit_CIE_1_EXAM
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num++ + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
