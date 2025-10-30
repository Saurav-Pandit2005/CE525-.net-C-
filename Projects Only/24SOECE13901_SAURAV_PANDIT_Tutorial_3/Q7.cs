using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_3
{
    class student
    {
        public int EnrolmentNo;
        public string Name;

        // Parameterized constructor
        public student(int enrolmentNo, string name)
        {
            EnrolmentNo = enrolmentNo;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("Name        : " + Name);
        }
    }
    internal class Q7
    {
        static void Main(string[] args)
        {
            student s1 = new student(101, "Saurav");
            student s2 = new student(102, "Rahul");

            s1.Display();
            Console.WriteLine("--------------------------");
            s2.Display();
        }
    }
}
