using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redditv2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Timestamp { get; set; }
        public int Score { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
