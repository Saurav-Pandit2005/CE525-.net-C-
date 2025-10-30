using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    public class A // Base class
    {
        public A(int value)
        {
            // Executes some code in the constructor
            Console.WriteLine("Base constructor A()");
        }
    }

    public class B : A // Derived class
    {
        public B(int value) : base(value)
        {
            // Base constructor is called first
            // Then this code is executed
            Console.WriteLine("Derived constructor B()");
        }
    }
    internal class Q5
    {
        static void Main()
        {
            // Create base class object
            A a = new A(0);

            // Create derived class object
            B b = new B(1);
        }
    }
}
