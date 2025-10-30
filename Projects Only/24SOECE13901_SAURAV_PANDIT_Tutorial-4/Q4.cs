using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    class StaticVar
    {
        public static int num;  // static variable

        // Constructor (increments num each time object is created)
        public StaticVar()
        {
            num++;
        }

        // Missing statement: static method to return num
        public static int getNum()
        {
            return num;
        }
    }

    internal class Q4
    {
        static void Main(string[] args)
        {
            // Creating 3 objects (each constructor call increments num)
            new StaticVar();
            new StaticVar();
            new StaticVar();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            Console.ReadKey();
        }
    }
}
