using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "Greenfox";
            Greet(a1);
            Console.ReadKey();
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Greetings dear, {name}");
        }
    }
}
