using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_4
{
    class Employee
    {
        public string EmpCode;
        public string Name;
        public string Designation;
        public double BasicPay;
        public double HRA;
        public double DA;
        public double TotalPay;

        public Employee(string empCode, string name, string designation, double basicPay)
        {
            EmpCode = empCode;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        // Method to calculate HRA, DA, and total pay
        public void CalPay()
        {
            HRA = 0.10 * BasicPay;   // HRA = 10% of basic pay
            DA = 0.45 * BasicPay;    // DA = 45% of basic pay
            TotalPay = BasicPay + HRA + DA;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Code: " + EmpCode);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Basic Pay: " + BasicPay);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Total Pay: " + TotalPay);
            Console.WriteLine("-------------------------------");
        }
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            // Creating objects for three employees
            Employee emp1 = new Employee("E001", "Mohin", "Manager", 50000);
            Employee emp2 = new Employee("E002", "Rahul", "Developer", 40000);
            Employee emp3 = new Employee("E003", "Saurav", "Analyst", 35000);

            // Calculate pay and display details
            emp1.CalPay();
            emp1.DisplayDetails();

            emp2.CalPay();
            emp2.DisplayDetails();

            emp3.CalPay();
            emp3.DisplayDetails();
        }

    }
}
