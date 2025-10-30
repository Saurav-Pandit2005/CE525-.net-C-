using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q9
    {
        static void UniqueNumber(int[] arr)
        {
            int xor = 0;
            foreach (int num in arr)
                xor ^= num;

            // Find rightmost set bit
            int rightmostSetBit = xor & -xor;

            int num1 = 0, num2 = 0;

            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) != 0)
                    num1 ^= num;
                else
                    num2 ^= num;
            }

            Console.WriteLine(num1 + " " + num2);
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            Console.Write("Output for Example 1: ");
            UniqueNumber(arr1);

            int[] arr2 = { 2, 1, 3, 2 };
            Console.Write("Output for Example 2: ");
            UniqueNumber(arr2);

            Console.ReadLine();
        }
    }
}
