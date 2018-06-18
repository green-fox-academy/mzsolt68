using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some text:");
            string text = Console.ReadLine();

            IEnumerable<char> upperCharsWithquery = from ch in text
                                          where char.IsUpper(ch)
                                          select ch;
            IEnumerable<char> upperCharsWithMethod = text.Where(ch=>char.IsUpper(ch));
            Console.WriteLine("\n Uppercase characters");
            Console.WriteLine("With query:");
            foreach (var ch in upperCharsWithquery)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine("\nWith method:");
            foreach (var ch in upperCharsWithMethod)
            {
                Console.Write($"{ch} ");
            }
            Console.ReadLine();
        }
    }
}
