using Assignment.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.Services
{
    public class CategoryApiClient: ICategoryApiClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public CategoryApiClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IList<CategoryRespone>> GetCategory()
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44303/api/Category");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<CategoryRespone>>();
        }
    }
}
