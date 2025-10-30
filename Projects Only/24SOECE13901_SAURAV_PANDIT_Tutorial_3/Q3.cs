using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_3
{
    // Student class
    class Student
    {
        // Data members (private fields)
        private int rollNo;
        private string name;
        private double marks;

        // Properties (to access private fields safely)
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        // Default constructor
        public Student()
        {
            rollNo = 0;
            name = "Unknown";
            marks = 0.0;
        }

        // Parameterized constructor
        public Student(int rollNo, string name, double marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        // Method to display student details
        public void DisplayStudent()
        {
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name   : " + name);
            Console.WriteLine("Marks  : " + marks);
        }

        // Method to check result
        public void CheckResult()
        {
            if (marks >= 40)
                Console.WriteLine(name + " has Passed.");
            else
                Console.WriteLine(name + " has Failed.");
        }
    }

    class Q3
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Student s1 = new Student();
            Console.WriteLine("Student 1 (Default):");
            s1.DisplayStudent();
            s1.CheckResult();

            Console.WriteLine("--------------------------");

            // Using parameterized constructor
            Student s2 = new Student(101, "Saurav", 85.5);
            Console.WriteLine("Student 2 (Parameterized):");
            s2.DisplayStudent();
            s2.CheckResult();

            Console.WriteLine("--------------------------");

            // Using properties to set values
            Student s3 = new Student();
            s3.RollNo = 102;
            s3.Name = "Rahul";
            s3.Marks = 32.0;

            Console.WriteLine("Student 3 (Using Properties):");
            s3.DisplayStudent();
            s3.CheckResult();

            Console.WriteLine("--------------------------");

            // Student 4 (Parameterized constructor)
            Student s4 = new Student(103, "Anita", 67.5);
            Console.WriteLine("Student 4:");
            s4.DisplayStudent();
            s4.CheckResult();

            Console.WriteLine("--------------------------");

            // Student 5 (Using properties)
            Student s5 = new Student();
            s5.RollNo = 104;
            s5.Name = "Vikas";
            s5.Marks = 45.0;
            Console.WriteLine("Student 5:");
            s5.DisplayStudent();
            s5.CheckResult();

        }
    }
}
