using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }

            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.ReadLine();
        }
    }
}
