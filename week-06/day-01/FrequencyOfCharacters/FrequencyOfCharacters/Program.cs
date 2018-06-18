using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some text:");
            string text = Console.ReadLine();

            char[] arrayFromText = text.ToCharArray();
            var frequencyWithQuery = from ch in arrayFromText
                                     group ch by ch into chars
                                     orderby chars.Key
                                     select new {chars.Key, Count = chars.Count() };
            var frequencyWithMethod = arrayFromText.GroupBy(ch => ch).OrderBy(chars => chars.Key);

            Console.WriteLine("Frequency of characters with query:");
            foreach (var ch in frequencyWithQuery)
            {
                Console.WriteLine($"{ch.Key}: {ch.Count}");
            }
            Console.WriteLine("\nFrequency of characters with method:");
            foreach (var ch in frequencyWithMethod)
            {
                Console.WriteLine($"{ch.Key}: {ch.Count()}");
            }

            Console.ReadLine();
        }
    }
}
