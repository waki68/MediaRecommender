using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.DTO
{
    public class RecommendedDTO
    {
        public string RecommendedId{ get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public string ImageURL{ get; set; }
        public string MediaURL{ get; set; }
    }
}
