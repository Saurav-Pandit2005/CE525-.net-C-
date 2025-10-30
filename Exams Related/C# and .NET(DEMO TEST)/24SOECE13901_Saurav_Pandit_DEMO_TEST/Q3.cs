using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_Saurav_Pandit_DEMO_TEST
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public void Display()
        {
            Console.WriteLine("ID is : " + id);
            Console.WriteLine("Name is : " + name);
            Console.WriteLine("Salary is : " + salary);
            Console.WriteLine("------------------------------");

        }
    }
    internal class Q3
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.id = 101;
            emp.name = "Saurav";
            emp.salary = 25000.00;
            emp.Display();

            Employee em = new Employee();
            em.id = 102;
            em.name = "Shubham";
            em.salary = 350000;
            em.Display();
        }
    }
}
