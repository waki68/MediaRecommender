using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.Models
{
    public class HBOResponse: IProviderResponse
    {
        public List<Recommend> Recommends { get; set; }
        public string Message { get; set; }
    }
}
