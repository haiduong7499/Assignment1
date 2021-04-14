using Assignment.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

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
            var respone = await product.GetAsync("https://localhost:44303/api/Product/GetProductByID/" + id);
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<ProductRespone>();
        }

        public async Task<IList<ProductRespone>> GetProductByCate(int idCate)
        {
            var product = _httpClientFactory.CreateClient();
            var respone = await product.GetAsync("https://localhost:44303/api/Product/GetProductByCategory/" + idCate);
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<IList<ProductRespone>>();
        }

        //public async Task<IList<RatingRespone>> AddRating(RatingRequest request)
        //{
        //    var product = _httpClientFactory.CreateClient();
        //    var respone = await product.PostAsJsonAsync("https://localhost:44303/api/Rating", request);
        //    respone.EnsureSuccessStatusCode();
        //    return await respone.Content.ReadAsAsync<IList<RatingRespone>>();
        //}


        public async Task<IList<RatingRespone>> GetRating(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44303/api/Rating/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<RatingRespone>>();
        }

        public async Task<RatingRequest> PostRating(RatingRequest ratingRequest)
        {
            var client = _httpClientFactory.CreateClient();
            //var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync("access_token");
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var json = JsonConvert.SerializeObject(ratingRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:44303/api/Rating", data);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<RatingRequest>();
        }
    }
}
