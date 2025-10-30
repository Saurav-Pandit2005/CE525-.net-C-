using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_Saurav_Pandit_CIE_1_EXAM
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

        public void CalPay()
        {
            HRA = 0.10 * BasicPay;
            DA = 0.45 * BasicPay;
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
            Employee emp1 = new Employee("1001", "Saurav", "Manager", 5000);
            Employee emp2 = new Employee("1003", "Denish", "Analyst", 3500);

            emp1.CalPay();
            emp1.DisplayDetails();

            emp2.CalPay();
            emp2.DisplayDetails();
        }

    }
}
