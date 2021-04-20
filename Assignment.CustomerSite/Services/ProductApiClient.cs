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
        private readonly HttpClient _client;

        public ProductApiClient(HttpClient client)
        {

            _client = client;
        }
        public async Task<IList<ProductRespone>> GetProducts()
        {
            
            var respone = await _client.GetAsync("api/Product");
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<IList<ProductRespone>>();
        }

        public async Task<ProductRespone> GetProductByID(string id)
        {
            var respone = await _client.GetAsync("api/Product/GetProductByID/" + id);
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<ProductRespone>();
        }

        public async Task<IList<ProductRespone>> GetProductByCate(int idCate)
        {
            var respone = await _client.GetAsync("api/Product/GetProductByCategory/" + idCate);
            respone.EnsureSuccessStatusCode();
            return await respone.Content.ReadAsAsync<IList<ProductRespone>>();
        }

        public async Task<IList<RatingRespone>> GetRating(string id)
        {
            var response = await _client.GetAsync("api/Rating/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<RatingRespone>>();
        }

        public async Task<RatingRequest> PostRating(RatingRequest ratingRequest)
        {


            var json = JsonConvert.SerializeObject(ratingRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("api/Rating", data);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<RatingRequest>();
        }
    }
}
