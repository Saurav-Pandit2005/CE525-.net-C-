using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    // Base class
    class Shape
    {
        public double Width;
        public double Height;

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    }

    // Derived class
    class Triangle : Shape
    {
        public string Style; // style of triangle

        // Return area of triangle
        public double Area()       // << Missing statement-1: return type and method signature
        {
            return Width * Height / 2;
        }

        // Display a triangle's style
        public void ShowStyle()    // << Missing statement-2: display Style
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }

    internal class Q2
    {
        static void Main()
        {
            // Correct object creation
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            // Assign values to t1
            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";

            // Assign values to t2
            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";

            // Display info for t1
            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());

            Console.WriteLine();

            // Display info for t2
            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());
        }
    }
}
