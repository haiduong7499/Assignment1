using Assignment.CustomerSite.Models;
using Assignment.CustomerSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryApiClient _cateApiClient;
        private readonly IProductApiClient _productApiClient;
        public HomeController(ILogger<HomeController> logger, ICategoryApiClient cateApiClient, IProductApiClient productApiClient)
        {
            _logger = logger;
            _cateApiClient = cateApiClient;
            _productApiClient = productApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var cate = await _cateApiClient.GetCategory();
            var product = await _productApiClient.GetProducts();
            var productCate = await _productApiClient.GetProductByCate(2);
            var productCate1 = await _productApiClient.GetProductByCate(1);
            ViewBag.ProductCate = productCate;
            ViewBag.ProductCate1 = productCate1;
            ViewBag.Product = product;
            ViewBag.Cate = cate;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
