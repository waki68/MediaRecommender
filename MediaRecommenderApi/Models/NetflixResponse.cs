using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.Models
{
    public class NetflixResponse: IProviderResponse
    {
        public bool succeeded { get; set; }
        public List<Media> result { get; set; }
        public NetflixError error { get; set; }
    }
}
