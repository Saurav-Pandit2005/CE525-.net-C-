using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_3
{
    class Line
    {
        private double length;   // Length of a line

        // Constructor
        public Line()
        {
            length = 10; // Missing statement-1: initialize length
            Console.WriteLine("Object is being created, length = " + length); // Missing statement-2
        }

        // Set length
        public void setLength(double len)
        {
            length = len; // Missing statement-3
        }

        // Get length
        public double getLength()
        {
            return length; // Missing statement-4
        }
    }
    internal class Q6
    {
        static void Main(string[] args)
        {
            Line line = new Line();   // Object creation

            // First display (default length 10)
            Console.WriteLine("Length of line : {0}", line.getLength());

            // Set new length
            line.setLength(6);

            // Second display (updated length 6)
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}
