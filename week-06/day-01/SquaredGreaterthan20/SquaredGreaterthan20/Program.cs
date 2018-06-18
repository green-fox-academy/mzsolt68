using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredGreaterthan20
{
    class Program
    {
        //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var greaterWithQuery = from num in n
                                   where num * num > 20
                                   select num;
            var greaterWithMethod = n.Where(num => num * num > 20);
            Console.WriteLine("With query:");
            foreach (var num in greaterWithQuery)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\nWith method:");
            foreach (var num in greaterWithMethod)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
    }
}
