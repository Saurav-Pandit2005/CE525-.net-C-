using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_Tutorial_3
{
    class Product
    {
        // Data members
        private string pcode;
        private string pname;
        private string mname;

        // Constructor
        public Product(string pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }
    internal class Q5
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                // Take input from command-line arguments
                string pcd = args[0];
                string pnm = args[1];
                string mnm = args[2];

                // Create Product object
                Product p = new Product(pcd, pnm, mnm);

                // Display product details
                p.Display();

                Console.ReadLine();
            }
        }
    }
}
