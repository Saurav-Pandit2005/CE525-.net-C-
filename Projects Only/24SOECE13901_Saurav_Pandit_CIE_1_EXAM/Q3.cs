using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_Saurav_Pandit_CIE_1_EXAM
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            int[] arr = {10,15,27,35,48,20,30,44,22,55};

            Console.Write("Enter element to search: ");
            int element = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine();

            if (found)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);

        }
    }
}
