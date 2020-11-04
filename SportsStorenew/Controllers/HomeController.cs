using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Domain;
using SportsStorenew.Domain.DB;
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
        public IActionResult Index(string categoryName, int page=1)
        {
            var products = _browsingAppService.GetProducts(new
                Service.Models.GetProductsRequest
            {
                CategoryName = categoryName ,
                PageSize = 8,
                Page =page
            });

            return View(products);
        }
        public IActionResult Details(int Id)
        {
            using(var Db = new SportsStoreDbContext())
            {
                var details = new  List<ProductDetails>();
                foreach (var item in Db.ProductImages.ToList())
                {
                    var productDetails = new ProductDetails();
                    if(item.ProductId==Id && item.IsThumbnail==false)
                    {
                        productDetails.DetailsImageUrl = item.ImageUrl;
                        productDetails.ProductName = Db.Products.Where(a => a.ProductId == item.ProductId).Select(a => a.Name).FirstOrDefault();
                        details.Add(productDetails);
                    }
                }
                return View(details);
            }
            
        }
    }
}
