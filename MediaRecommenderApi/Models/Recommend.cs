using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.Models
{
    public class Recommend
    {
        public string MediaId { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string ImageURL { get; set; }
        public string MediaURL { get; set; }
    }
}
