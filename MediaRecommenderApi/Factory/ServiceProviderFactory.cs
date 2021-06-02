using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaRecommenderApi.Services;

namespace MediaRecommenderApi.Factory
{
    public interface IServiceProviderFactory
    {
        IRecommendProvider GetRecommendProvider(string providerName);
    }
    public class ServiceProviderFactory: IServiceProviderFactory
    {
        public INetflixProvider NetflixProvider { get; }
        public IHBOProvider HboProvider { get; }

        public ServiceProviderFactory(INetflixProvider netflixProvider, IHBOProvider hboProvider)
        {
            NetflixProvider = netflixProvider;
            HboProvider = hboProvider;
        }
        public IRecommendProvider GetRecommendProvider(string providerName)
        {
            if (providerName == "HBO") return HboProvider as IRecommendProvider;
            if (providerName == "Netflix") return NetflixProvider as IRecommendProvider;
            else throw new NotImplementedException();
        }
    }
}
