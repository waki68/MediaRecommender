using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaRecommenderApi.Models;

namespace MediaRecommenderApi.DTO
{
    public class Resolver
    {
        public static RecommendedDTO Resolve(IProviderResponse response)
        {
            if(response.GetType().IsInstanceOfType(HBOResponse)) //....
            if (response.GetType().IsInstanceOfType(NetflixResponse)) //....

        }
    }
}
