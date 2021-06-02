using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.Models
{
    public class NetflixError
    {
        public string code { get; set; }
        public string message { get; set; }
        public string details { get; set; }
    }
}
