using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MediaRecommenderApi.Models;
using Newtonsoft.Json;

namespace MediaRecommenderApi.Services
{
    public interface IHBOProvider : IRecommendProvider { }

    public class HBOProvider: IHBOProvider
    {
        private readonly IHttpClientFactory _clientFactory;

        public HBOProvider(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IProviderResponse> GetRecommendation(string userId, int pageIndex, int pageSize)
        {
            HBOResponse result = null;
            var client = _clientFactory.CreateClient("HBO");
            client.BaseAddress = new Uri("http://www.hbo.com");
            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var requestUrl = "/users/recommended";

            var payload=new HBOPayload();
            payload.UserId = userId;
            payload.PageIndex = pageIndex;
            payload.PageSize = pageSize;

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            var stringPayload = JsonConvert.SerializeObject(payload, settings);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(requestUrl, httpContent);

            if (response.Content != null)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<HBOResponse>(responseContent);
            }

            return result;
        }
    }
}
