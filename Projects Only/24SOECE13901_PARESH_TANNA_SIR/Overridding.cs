using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_PARESH_TANNA_SIR
{
    class X
    {
        public int t;
        public virtual void Display()
        {
            Console.WriteLine(t);
        }

        public void Show()
        {
            Console.WriteLine(t);
        }
    }

    class Y : X
    {
        public int u;
        public override void Display()
        {
            Console.WriteLine(t);               //  Or  ===>  base.Display();
            Console.WriteLine(u);
        }
        public new void Show()
        {
            Console.WriteLine(t);
            Console.WriteLine(u);
        }
        public void Test()
        { }
    }


    internal class Overridding
    {
        public static void Main()
        {
            Y obj = new Y();
            //obj.t = 10;
            //obj.u = 20;
            obj.Display();      //from Y
            obj.Test();


            X obj2 = new Y();
            //obj2.t = 100;
            //obj2.u = 200; // u is not accessible because obj2 is of type X
            obj2.Display(); // Display of class Y will be called because it is overridden    from Y
            obj2.Show(); // Show of class X will be called because it is not overridden      from X
            //obj2.Test(); // Test is not accessible because obj2 is of type X                 from X         =====> Error
        }
    }
}
