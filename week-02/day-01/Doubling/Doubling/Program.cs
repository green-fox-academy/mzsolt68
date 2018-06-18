using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 123;
            Console.WriteLine(Doubling(baseNum));

            Console.ReadKey();
        }

        static int Doubling(int number)
        {
            return number * 2;
        }
    }
}
