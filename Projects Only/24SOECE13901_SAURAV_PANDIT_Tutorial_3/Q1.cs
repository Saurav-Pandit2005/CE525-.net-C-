using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_3
{

    class Car                       // Task 1: Create a class
    {

        // Task 2: Private Data Members
        private string brand;
        private string color;
        private int speed;

        public Car(string b, string c)              // Constructor 
        {
            brand = b;
            color = c;
            speed = 0;
        }

        // Task 3: Public Methods

        public void StartEngine()                   // Start Engine
        {
            Console.WriteLine(color + " " + brand + " Car is starting.");
        }

        public void Accelerate(int increment)       // Accelerate
        {
            speed = speed + increment;
            Console.WriteLine(brand + " is running at " + speed + " km/h.");
        }

        public void Brake(int decrement)            // Brake
        {
            speed = speed - decrement;
            if (speed < 0)
            {
                speed = 0;
            }
            Console.WriteLine(brand + " slowed down to " + speed + " km/h.");
        }
    }

    // Task 4: class with Main method
    class Q1
    {
        static void Main(string[] args)
        {
            // Task 5: Create at least two objects
            Car object1 = new Car("BMW", "Red");
            Car object2 = new Car("Audi", "Blue");


            object1.StartEngine();
            object1.Accelerate(50);
            object1.Brake(20);

            Console.WriteLine("-----------------------------");


            object2.StartEngine();
            object2.Accelerate(70);
            object2.Brake(40);

        }
    }
}
