using Assignment.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.Services
{
    public class ProductApiClient: IProductApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IList<ProductRespone>> GetProducts()
        {
            var product =_httpClientFactory.CreateClient();
            var respone = await product.GetAsync("https://localhost:44303/api/Product");
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<IList<ProductRespone>>();
        }

        public async Task<ProductRespone> GetProductByID(string id)
        {
            var product = _httpClientFactory.CreateClient();
            var respone = await product.GetAsync("https://localhost:44303/api/Product"+id);
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<ProductRespone>();
        }
    }
}
