using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_SAURAV_PANDIT_TUTORIAL_2
{
    internal class Q10
    {
        static bool SearchMatrix(int[,] mat, int n, int m, int x)
        {
            int row = 0;         // start from top-right corner
            int col = m - 1;

            while (row < n && col >= 0)
            {
                if (mat[row, col] == x)
                    return true;
                else if (mat[row, col] > x)
                    col--;  
                else
                    row++;   
            }
            return false;
        }

        static void Main()
        {
            int[,] mat = {
            { 10, 20, 30, 40 },
            { 15, 25, 35, 45 },
            { 27, 29, 37, 48 },
            { 32, 33, 39, 50 }
        };

            int n = mat.GetLength(0);
            int m = mat.GetLength(1);

            Console.Write("Enter element to search: ");
            int x = int.Parse(Console.ReadLine());

            if (SearchMatrix(mat, n, m, x))
                Console.WriteLine("Element {0} is present in matrix.", x);
            else
                Console.WriteLine("Element {0} is NOT present in matrix.", x);
        }
    }
}
