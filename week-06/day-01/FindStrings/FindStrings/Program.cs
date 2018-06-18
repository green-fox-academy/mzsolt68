using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStrings
{
    class Program
    {
        //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var citiesWithQuery = from city in cities
                                  where city.StartsWith("A") && city.EndsWith("I")
                                  select city;
            var citiesWithMethod = cities.Where(city=>city.StartsWith("A") && city.EndsWith("I"));
            Console.WriteLine("With query:");
            foreach (var city in citiesWithQuery)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("\nWith method:");
            foreach (var city in citiesWithMethod)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
