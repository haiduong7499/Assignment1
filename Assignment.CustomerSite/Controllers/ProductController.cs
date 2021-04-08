using Assignment.CustomerSite.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Detail(string id)
        {
            var product = _productApiClient.GetProductByID(id);
            return View(product);
        }
    }
}
