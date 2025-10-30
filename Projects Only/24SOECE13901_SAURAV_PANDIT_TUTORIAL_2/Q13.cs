using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q13
    {
        static void Main()
        {
            Console.Write("Enter the amount: ");
            int amount = int.Parse(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note; // how many notes of this type
                amount = amount % note;    // remaining amount

                Console.WriteLine("Notes of Rs.{0} = {1}", note, count);
            }
        }
    }
}
