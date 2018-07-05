using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWithEF.Models
{
    public class Assignee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Todo> AssignedTodos { get; set; }
    }
}
