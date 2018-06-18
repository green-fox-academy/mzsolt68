using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfPositiveNumbers
{
    class Program
    {
        //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaredWithQuery = from num in n
                                   where num > 0
                                   select num * num;
            var squaredWithMethod = n.Where(num => num > 0).Select(num => num * num);

            Console.WriteLine("Squared with query:");
            foreach (var num in squaredWithQuery)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\nSquared with method:");
            foreach (var num in squaredWithMethod)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
    }
}
