using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfOddNumbers
{
    class Program
    {
        //Write a LINQ Expression to get the average value of the odd numbers from the following array:

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var averageWithQuery = (from num in n
                                    where num % 2 != 0
                                    select num).Average();
            var averageWithMethod = n.Where(num => num % 2 != 0).Average();
            Console.WriteLine($"Average with query: {averageWithQuery}");
            Console.WriteLine($"Average with method: {averageWithMethod}");
            Console.ReadLine();
        }
    }
}
