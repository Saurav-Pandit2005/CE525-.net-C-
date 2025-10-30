using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q12
    {
        static void Main()
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int x = int.Parse(Console.ReadLine());

            bool found = false;

            // Linear Search
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("1");  // Element found
            else
                Console.WriteLine("0");  // Element not found
        }
    }
}
