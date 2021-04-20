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
        private readonly HttpClient _client;

        public CategoryApiClient(HttpClient client)
        {
            _client = client;
        }
        public async Task<IList<CategoryRespone>> GetCategory()
        {
            
            var response = await _client.GetAsync("api/Category");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<CategoryRespone>>();
        }
    }
}
