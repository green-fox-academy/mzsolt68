using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoMVC.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public DateTime Completed { get; set; }
        public bool IsUrgent { get; set; }
    }
}
