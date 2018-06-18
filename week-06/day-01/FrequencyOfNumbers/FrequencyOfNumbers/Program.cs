using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfNumbers
{
    class Program
    {
        //Write a LINQ Expression to find the frequency of numbers in the following array:

        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var frequencyWithQuery = from number in n
                                     group number by number into nums
                                     orderby nums.Key
                                     select new { nums.Key, Count = nums.Count() };
            var frequencyWithMethod = n.GroupBy(num => num).OrderBy(grp => grp.Key);

            Console.WriteLine("Frequency with query:");
            foreach (var obj in frequencyWithQuery)
            {
                Console.WriteLine($"{obj.Key}: {obj.Count}");
            }
            Console.WriteLine("\nFrequency with method:");
            foreach (var obj in frequencyWithMethod)
            {
                Console.WriteLine($"{obj.Key}: {obj.Count()}");
            }
            Console.ReadLine();
        }
    }
}
