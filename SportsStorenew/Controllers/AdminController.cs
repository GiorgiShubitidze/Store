using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service;
using SportsStoreNew.Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SportsStorenew.Controllers
{
    [Authorize]

    public class AdminController : Controller
    {
        IBrowsingAppService _browsingAppService;

        public AdminController(IBrowsingAppService browsingAppService)
        {
            _browsingAppService = browsingAppService;
        }
        // GET: AdminController
        public IActionResult Index(string categoryName, string productName, int page = 1)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == "d50f6504-2a9a-410e-a93e-8e1ba5cec432" || userId == "7ae2496b-9439-4e39-a29b-e56326607b7c")
            {
                var products = _browsingAppService.GetProducts(new
                GetProductsRequest
                {
                    CategoryName = categoryName,
                    PageSize = 8,
                    Page = page,
                    Name = productName
                });
                return View(products);
            }
            else
            {
                return RedirectToAction("index", "Home");
            }
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public IActionResult Edit(int ProductId)
        {
            SportsStoreDbContext dbContext = new SportsStoreDbContext();
            var x = dbContext.Products.Where(a => a.ProductId == ProductId).FirstOrDefault();
            return View(x);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            SportsStoreDbContext dbContext = new SportsStoreDbContext();
            var x = dbContext.Products.FirstOrDefault(item => item.ProductId == product.ProductId);
            if (x != null)
            {
                x.DiscountPrice = product.DiscountPrice;
                x.Name = product.Name;
                x.Price =product.Price;
                x.Description = product.Description;
                dbContext.SaveChanges();
                return RedirectToAction("index");
            }

            return RedirectToAction("index");
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public static bool SendMail(string userMail , string subject , string body , bool isHtml = false)
        {
            
            return true;
        }
       
    }
}
