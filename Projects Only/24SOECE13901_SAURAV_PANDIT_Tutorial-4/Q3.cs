using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    // Task 1: Create a class
    class Person
    {
        // Task 2: Add data members with different access specifiers
        private int id;           
        protected int age;       
        public string name;       

        // Task 3: Public methods to work with data members
        public void SetDetails(int id, int age, string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Person Details:");
            Console.WriteLine("ID:" + id + ", Age:" + age + ", Name: " + name);
        }
    }

    // Task 4: Create another class inheriting Person
    class employee : Person
    {
        // Task 5: Add data members with different access specifiers
        private string empCode;      
        protected string department; 
        public double salary;        

        // Task 6: Public methods to work with data members
        public void SetempDetails(string empCode, string department, double salary)
        {
            this.empCode = empCode;
            this.department = department;
            this.salary = salary;
        }

        public void ShowempDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name:" + name + ", Age:" + age + ", EmpCode: " + empCode + ", Department:" + department + ", Salary: " + salary);
        }
    }

    internal class Q3
    {
        static void Main()
        {
            // Task 8: Create two objects of Employee
            employee e1 = new employee();
            employee e2 = new employee();

            e1.SetDetails(101, 25, "Saurav");
            e1.SetempDetails("E001", "IT", 50000);
            e1.ShowDetails();
            e1.ShowempDetails();

            Console.WriteLine();

            e2.SetDetails(102, 30, "Haresh");
            e2.SetempDetails("E002", "HR", 60000);
            e2.ShowDetails();
            e2.ShowempDetails();
        }
    }
}
