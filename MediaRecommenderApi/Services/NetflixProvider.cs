using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MediaRecommenderApi.Models;

namespace MediaRecommenderApi.Services
{
    public interface INetflixProvider: IRecommendProvider { }
    public class NetflixProvider: INetflixProvider
    {
        private readonly IHttpClientFactory _clientFactory;

        public NetflixProvider(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IProviderResponse> GetRecommendation(string userId, int pageIndex, int pageSize)
        {
            NetflixResponse result = null;
            var client = _clientFactory.CreateClient("Netflix");
            client.BaseAddress = new Uri("http://www.netflix.com");
            var response = await client.GetAsync($"/recommend-medias?userId={userId}&pi={pageIndex}&ps={pageSize}");
            if (response.IsSuccessStatusCode)
            {
                using (var responseStream=await response.Content.ReadAsStreamAsync())
                {
                    result = await JsonSerializer.DeserializeAsync<NetflixResponse>(responseStream);
                }
            }

            return result;
        }
    }
}
