using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SportsStorenew.Service;
using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service;
using SportsStoreNew.Service.Models;

namespace SportsStoreNew.Controllers
{
    [Authorize]
   
    public class HomeController : Controller
    {
        IBrowsingAppService _browsingAppService;
        
        
        public HomeController(IBrowsingAppService browsingAppService)
        {
            _browsingAppService = browsingAppService;
        }
        // GET: HomeController
      [AllowAnonymous]
        public IActionResult Index(string categoryName, string productName, int page = 1)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var products = _browsingAppService.GetProducts(new
                Service.Models.GetProductsRequest
            {
                CategoryName = categoryName,
                PageSize = 8,
                Page = page,
                Name = productName
            });
            return View(products);
        }

        [AllowAnonymous]
        public IActionResult Details(int Id)
        {
            var product = _browsingAppService.GetProduct(Id);
            return View(product); 
        }

    }
}
