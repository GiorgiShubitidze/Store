using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Service;

namespace SportsStorenew.Controllers
{
    public class HomeController : Controller
    {
        IBrowsingAppService _browsingAppService;
        public HomeController(IBrowsingAppService browsingAppService)
        {
            _browsingAppService = browsingAppService;
        }
        // GET: HomeController
        public IActionResult Index(string categoryName)
        {
            var products = _browsingAppService.GetProducts(new
                Service.Models.GetProductsRequest
            {
                CategoryName = categoryName
            });

            return View(products);
        }
    }
}
