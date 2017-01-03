using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spence_collection.Models
{
    public class ArtworkAttribute
    {
        public int artwork_id { get; set; }
        public int attribute_id { get; set; }
        public string value { get; set; }
    }
}
