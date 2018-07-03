using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWithEF.Models
{
    public class Todo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        [DefaultValue(false)]
        public bool IsUrgent { get; set; }
        [DefaultValue(false)]
        public bool IsDone { get; set; }
    }
}
