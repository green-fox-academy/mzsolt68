using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Greeting
    {
        static long counter;
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting()
        {
            counter++;
            this.Id = counter;
            this.Content = "Hello, ";
        }
    }
}
