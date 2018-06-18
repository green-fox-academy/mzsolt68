using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberFromArray
{
    class Program
    {
        //Write a LINQ Expression to get the even numbers from the following array:
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNUmbersWithQuery = from number in n
                                       where number % 2 == 0
                                       select number;
            var evenNumbersWithMethod = n.Where(number => number % 2 == 0);
            foreach (var number in evenNUmbersWithQuery)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            foreach (var number in evenNumbersWithMethod)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
