using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
        public IActionResult Index(string categoryName, string productName, int page=1)
        {


            var products = _browsingAppService.GetProducts(new
                Service.Models.GetProductsRequest
            {
                CategoryName = categoryName ,
                PageSize = 8,
                Page =page,
                Name = productName
                
            });

            return View(products);
        }
       
        public IActionResult AddToCart(int  ProductId)
        {
            DateTime localDate = DateTime.Now;
            using (var Db = new SportsStoreDbContext())
            {
                var Cart = new AddToCart {  DateTime = localDate, CartsProductId = ProductId };
                Db.AddToCarts.Add(Cart);
                Db.SaveChanges();
            }
                return View();
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
                        productDetails.Description = Db.Products.Where(a => a.ProductId == item.ProductId).Select(a => a.Description).FirstOrDefault();
                        productDetails.ProductPrice = Db.Products.Where(a => a.ProductId == item.ProductId).Select(a => a.Price).FirstOrDefault();
                        details.Add(productDetails);
                    }
                }
                return View(details);
            }
            
        }

    }
}
