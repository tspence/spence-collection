using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spence_collection.Models
{
    public class Story
    {
        public string story_id { get; set; }
        public string visible { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string date { get; set; }
        public string preface { get; set; }
        public string content { get; set; }
    }
}
