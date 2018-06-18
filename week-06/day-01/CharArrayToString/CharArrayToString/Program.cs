using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = {'A', 'b','r','a','k','a','d','a','b','r','a' };
            var text = string.Join("",charArray.Select(x=>x));
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
