using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_PARESH_TANNA_SIR
{
    internal class Employee
    {
        int EmpId;
        String Name;
        String Cty;
    }

     public Employee(int EmpId, String Name)
        {
            this.EmpId = EmpId;
            this.Name = Name;
        }

        public Employee(int EmpId, String Name, String city) : this(EmpId, Name)
        {
            this.city = city;
        }

        public void display()
        {

        }

        public static void main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(101, "Saurav", "Rajkot");
            obj2.Display();
        }
    }
