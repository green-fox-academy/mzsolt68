using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Models;

namespace TodoWithEF.ViewModels
{
    public class TodoAssigneeViewModel
    {
        public Todo Todo { get; set; }
        public List<Assignee> Assignees { get; set; }
    }
}
