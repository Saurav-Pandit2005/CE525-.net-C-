using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_3
{
    class Clock
    {
        // Private data members
        private int hour;
        private int min;
        private int sec;

        // No-argument constructor (default time 12:00:00)
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        // Three-argument constructor
        public Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        // Method to increment time by one second
        public void Tick()
        {
            sec = sec + 1; // Increase seconds by 1

            if (sec == 60)
            {
                sec = 0;
                min = min + 1;
            }

            if (min == 60)
            {
                min = 0;
                hour = hour + 1;
            }

            if (hour == 24)
            {
                hour = 0;
            }
        }

        // Method to display current time (simple version)
        public void DisplayTime()
        {
            Console.WriteLine("Time = " + hour + ":" + min + ":" + sec);
        }

        // Getter methods
        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return min;
        }

        public int GetSeconds()
        {
            return sec;
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            // Using no-argument constructor
            Clock clock1 = new Clock();
            Console.WriteLine("Clock1 initial time:");
            clock1.DisplayTime();

            clock1.Tick(); // increment by 1 second
            Console.WriteLine("Clock1 after 1 tick:");
            clock1.DisplayTime();

            Console.WriteLine("-----------------------------");

            // Using three-argument constructor
            Clock clock2 = new Clock(23, 59, 58);
            Console.WriteLine("Clock2 initial time:");
            clock2.DisplayTime();

            clock2.Tick(); // 23:59:58 → 23:59:59
            clock2.DisplayTime();

            clock2.Tick(); // 23:59:59 → 00:00:00
            clock2.DisplayTime();

            // Using getter methods
            Console.WriteLine("Hour: " + clock2.GetHour());
            Console.WriteLine("Minute: " + clock2.GetMinute());
            Console.WriteLine("Second: " + clock2.GetSeconds());

        }
    }
}
