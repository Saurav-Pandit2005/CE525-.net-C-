using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{

    class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }

    class Y : X
    {
        sealed protected override void F() { Console.WriteLine("Y.F"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }
    }

    class Z : Y
    {
        // ❌ Cannot override F because it's sealed in Y
        // protected override void F() { Console.WriteLine("Z.F"); } // ERROR REMOVED

        // ✅ Allowed, since F2 is not sealed
        protected override void F2() { Console.WriteLine("Z.F2"); }
    }
    internal class Q8
    {
        static void Main()
        {
            X Obj1 = new X();
            Obj1.F();   // X.F
            Obj1.F2();  // X.F2

            Y Obj2 = new Y();
            Obj2.F();   // Y.F
            Obj2.F2();  // Y.F2

            Z Obj3 = new Z();
            // Obj3.F();  // Calls Y.F (since Z cannot override it)
            Obj3.F2();  // Z.F2
        }
    }
}
