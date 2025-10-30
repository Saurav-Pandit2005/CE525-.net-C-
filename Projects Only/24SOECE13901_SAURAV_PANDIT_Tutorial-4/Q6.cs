using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{

    abstract class Test
    {
        protected int a;             // protected so derived classes can access it

        public abstract void A();    // must have access modifier
    }

    class Example1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example1.A");
            a++; 
            Console.WriteLine("a = " + a);
        }
    }

    class Example2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example2.A");
            a--; 
            Console.WriteLine("a = " + a);
        }
    }
    internal class Q6
    {
        static void Main()
        {
            Test test1 = new Example1();
            test1.A();

            Test test2 = new Example2();
            test2.A();
        }
    }
}
