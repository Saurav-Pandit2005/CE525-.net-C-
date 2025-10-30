using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    internal class Q9
    {
            public static void Main()
            {
                int x = 0;
                int div = 0;

                try
                {
                    div = 100 / x;   
                    Console.WriteLine("Result: " + div);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    Console.WriteLine("Exception details: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Program execution completed (finally block executed).");
                }
            }
    }
}
