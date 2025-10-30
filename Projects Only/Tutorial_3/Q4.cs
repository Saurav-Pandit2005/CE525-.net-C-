using System;

namespace Tutorial_3
{
    // Student class (same as Q3 but cleaned)
    class student
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
                if (value >= 0 && value <= 100)
                    marks = value;
                else
                    marks = 0;
            }
        }

        // Default Constructor
        public student()
        {
            rollNo = 0;
            name = "Unknown";
            course = "Not Assigned";
            marks = 0.0;
        }

        // Parameterized Constructor
        public student(int rollNo, string name, string course, double marks)
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
            Console.WriteLine($"Result  : {GetResult()}");
        }

        // Method: Check Result
        public string GetResult()
        {
            return (marks >= 40) ? "Pass" : "Fail";
        }
    }

    // Another class in the same file
    internal class Q4
    {
        static void Main(string[] args)
        {
            // Creating 5 Student objects using parameterized constructor
            Student s1 = new Student(101, "Saurav Pandit", "Computer Engineering", 85.5);
            Student s2 = new Student(102, "Amit Sharma", "Information Technology", 35);
            Student s3 = new Student(103, "Priya Verma", "Electronics", 72);
            Student s4 = new Student(104, "Rohit Mehta", "Mechanical", 90);
            Student s5 = new Student(105, "Neha Gupta", "Civil", 55);

            // Store in an array
            Student[] students = { s1, s2, s3, s4, s5 };

            // Loop through and display details
            foreach (Student s in students)
            {
                s.Display();
                Console.WriteLine("----------------------------");
            }

            // Keep console open
            Console.ReadLine();
        }
    }
}
