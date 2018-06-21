using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    class Todo
    {
        public int id { get; set; }
        public string text { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime completedAt { get; set; }

        public Todo(int id, string text, string status, DateTime createdAt, DateTime completedAt)
        {
            this.id = id;
            this.text = text;
            this.status = status;
            this.createdAt = createdAt;
            this.completedAt = completedAt;
        }

        public override string ToString()
        {
            return $"ID={id} text {text} created at {createdAt.Year}-{createdAt.Month}-{createdAt.Day}";
        }
    }
}
