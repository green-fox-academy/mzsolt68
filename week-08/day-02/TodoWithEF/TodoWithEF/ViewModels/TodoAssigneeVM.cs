using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Models;

namespace TodoWithEF.ViewModels
{
    public class TodoAssigneeVM
    {
        //public int TodoId { get; set; }
        //public string Title { get; set; }
        //public bool IsUrgent { get; set; }
        //public bool IsDone { get; set; }
        public Todo Todo { get; set; }
        public List<Assignee> Assignees { get; set; }
    }
}
