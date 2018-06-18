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

            char[] arrayFromText = text.ToCharArray();
            var upperCharsWithquery = from ch in arrayFromText
                                          where char.IsUpper(ch)
                                          select ch;
            var upperCharsWithMethod = arrayFromText.Where(ch=>char.IsUpper(ch));
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
