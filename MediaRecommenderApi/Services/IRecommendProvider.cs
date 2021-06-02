using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaRecommenderApi.Models;

namespace MediaRecommenderApi.Services
{
    public interface IRecommendProvider
    {
        Task<IProviderResponse> GetRecommendation(string userId, int pageIndex, int pageSize);
    }
}
