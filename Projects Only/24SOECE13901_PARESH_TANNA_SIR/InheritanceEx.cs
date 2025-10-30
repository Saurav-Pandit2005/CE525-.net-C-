using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_PARESH_TANNA_SIR
{
    internal class InheritanceEx
    {
        class Person
        {
            protected int ID;
            public string Name;
            protected string City;


            public Person(int ID, string Name, string City)
            {
                this.ID = ID;
                this.Name = Name;
                this.City = City;
            }
        }

        class Employee : Person
        {
            private int Salary;
            public Employee(int ID, string Name, string City, int Salary) : base(ID, Name, City)
            {
                this.Salary = Salary;
            }
            public void display()
            {
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("City: " + City);
                Console.WriteLine("Salary: " + Salary);
            }
        }
    }
}
