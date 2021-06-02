using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaRecommenderApi.DTO;
using MediaRecommenderApi.Factory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediaRecommenderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IServiceProviderFactory ProviderFactory { get; }
        public IConfiguration Configuration { get; }

        public UserController(IServiceProviderFactory providerFactory, IConfiguration configuration)
        {
            ProviderFactory = providerFactory;
            Configuration = configuration;
        }

        [HttpGet("recommend")]
        public async Task<IActionResult> GetRecommendation(string userId, int pageIndex, int pageSize)
        {
            var providerName = Configuration.GetSection("RecommenderProvider").Value;
            var result=await ProviderFactory.GetRecommendProvider(providerName).GetRecommendation(userId, pageIndex, pageSize);
            // A method needed to resolve result from service to DTO and return it to the client
            var resolved=Resolver.Resolve(result);
            return //
        }

    }
}
