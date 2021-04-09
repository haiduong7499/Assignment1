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
        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }
        public async Task<IActionResult> Index(int id)
        {
            var productCate = await _productApiClient.GetProductByCate(id);
            ViewBag.ProductCate = productCate;
            return View();
        }
        public async Task<IActionResult> Detail(string id)
        {
            var product = await _productApiClient.GetProductByID(id);

            return View(product);
        }

        public async Task<IActionResult> ShowProductByCate(int idCate)
        {

            var product = await _productApiClient.GetProductByCate(idCate);
            return View(product);
        }
    }
}
