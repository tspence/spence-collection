using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spence_collection.Models
{
    public class Artist
    {
        public int artist_id { get; set; }
        public string artist_name { get; set; }
        public string last_name { get; set; }
        public string biography { get; set; }
        public string url { get; set; }
        public string email { get; set; }
    }
}
