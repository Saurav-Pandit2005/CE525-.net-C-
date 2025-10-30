using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_3
{
    // Student class
    class Student
    {
        // Private Data Members
        private int rollNo;
        private string name;
        private string course;
        private double marks;

        // Public Properties (Encapsulation)
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

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public double Marks
        {
            get { return marks; }
            set
            {
                if (value >= 0 && value <= 100) // validation
                    marks = value;
                else
                    marks = 0;
            }
        }

        // Default Constructor
        public Student()
        {
            rollNo = 0;
            name = "Unknown";
            course = "Not Assigned";
            marks = 0.0;
        }

        // Parameterized Constructor
        public Student(int rollNo, string name, string course, double marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.course = course;
            this.marks = (marks >= 0 && marks <= 100) ? marks : 0; // validation
        }

        // Method: Display student details
        public void Display()
        {
            Console.WriteLine("----- Student Details -----");
            Console.WriteLine($"Roll No : {rollNo}");
            Console.WriteLine($"Name    : {name}");
            Console.WriteLine($"Course  : {course}");
            Console.WriteLine($"Marks   : {marks}");
        }

        // Method: Check Result
        public string GetResult()
        {
            if (marks >= 40)
                return "Pass";
            else
                return "Fail";
        }
    }

    // Another class in the same file
    internal class TestStudent
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Student s1 = new Student();
            s1.Display();
            Console.WriteLine($"Result  : {s1.GetResult()}");

            Console.WriteLine("----------------------------");

            // Using parameterized constructor
            Student s2 = new Student(101, "Saurav Pandit", "Computer Engineering", 85.5);
            s2.Display();
            Console.WriteLine($"Result  : {s2.GetResult()}");

            Console.WriteLine("----------------------------");

            // Using properties
            Student s3 = new Student();
            s3.RollNo = 102;
            s3.Name = "Amit Sharma";
            s3.Course = "Information Technology";
            s3.Marks = 35; // Fail case
            s3.Display();
            Console.WriteLine($"Result  : {s3.GetResult()}");

            // Keep console open
            Console.ReadLine();
        }
    }
}
