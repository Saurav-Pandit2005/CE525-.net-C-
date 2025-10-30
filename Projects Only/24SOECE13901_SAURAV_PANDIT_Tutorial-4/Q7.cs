using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{

    sealed class AB
    {
        public int x;
        public int y;
    }
    internal class Q7
    {
        static void Main()
        {
            AB sc = new AB();
            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
