using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    class MyException : Exception
    {
        // Constructor that accepts a string message
        public MyException(string message) : base(message)
        {
        }
    }

    internal class Q10
    {
        public static void Main()
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
