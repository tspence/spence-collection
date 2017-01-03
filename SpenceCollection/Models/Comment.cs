using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spence_collection.Models
{
    public class Comment
    {
        public int comment_id { get; set; }
        public int artwork_id { get; set; }
        public int author_id { get; set; }
        public string comment_date { get; set; }
        public string content { get; set; }
    }
}
