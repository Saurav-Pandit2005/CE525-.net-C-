using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_Saurav_Pandit_CIE_1_EXAM
{
    class Book
    {
        public int bookId;
        public string title;
        public double price;
    }
    internal class Q6
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.bookId = 1101;
            b1.title = "Logic Building";
            b1.price = 250.00;
            //display first book details

            Console.WriteLine("Book Id is : " + b1.bookId);
            Console.WriteLine("Book Tittle is : " + b1.title);    
            Console.WriteLine("Book Price is : " + b1.price);

        }
    }
}
