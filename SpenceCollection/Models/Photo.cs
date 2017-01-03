using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spence_collection.Models
{
    public class Photo
    {
        public int photo_id { get; set; }
        public int artist_id { get; set; }
        public int artwork_id { get; set; }
        public int story_id { get; set; }
        public int is_default { get; set; }
        public string caption { get; set; }
        public string photographer { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int thumb_height { get; set; }
        public int thumb_width { get; set; }
        public int med_height { get; set; }
        public int med_width { get; set; }
        public int sort_order { get; set; }
    }
}
