using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_Saurav_Pandit_DEMO_TEST
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // reverse order (without using built-in functions)
            Console.WriteLine("\n\nArray in Reverse Order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
