using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "Kuty";
            Console.WriteLine(AppendA(am));

            Console.ReadKey();
        }

        static string AppendA(string text)
        {
            return text + "a";
        }
    }
}
