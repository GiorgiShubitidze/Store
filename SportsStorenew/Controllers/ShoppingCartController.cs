using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Service;
using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Models;
using SportsStoreNew.Service;
using SportsStoreNew.Service.Models;

namespace SportsStoreNew.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {

        SportsStoreDbContext _databaseContext;
        ICheckDataService _ichekdataservice;
        ICartItems _cartItems;
        public ShoppingCartController(SportsStoreDbContext Db, ICheckDataService ichekdataservice, ICartItems cartItems)
        {
            _ichekdataservice = ichekdataservice;
            _databaseContext = Db;
            _cartItems = cartItems;
        }
        DateTime localDate = DateTime.Now;
        // private ShoppingCart _shoppingCart;
        //private ShoppingCart _shoppingCart;
        public IActionResult AddToShoppingCart(int ProductId, int CategoryId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.Identity.Name;
            var Category = _databaseContext.Categories.Where(a => a.CategoryId == CategoryId).Select(a => a.Name).FirstOrDefault();
            if (userId == null)
            {
                return RedirectToAction("Index", "Home", new { categoryName = Category });
            }
            var Cart = new AddToCart { DateTime = localDate, UserId = userId, UserName = userName, ProductId = ProductId };
            _databaseContext.AddToCarts.Add(Cart);
            _databaseContext.SaveChanges();
            return RedirectToAction("Index", "Home", new { categoryName = Category });
        }
        public IActionResult ProductCountForUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var count = -_databaseContext.AddToCarts.Where(a => a.UserId == userId).Count();
            var productCount = new ProductCount();
            productCount.Count = count;
            return View(productCount);
        }


        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(CheckoutViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Chek = _ichekdataservice.Check(model);
                if (Chek == true)
                {
                    return RedirectToAction("SuccessCheck", "ShoppingCart");
                }
            }

            return View();
        }
        public IActionResult SuccessCheck()
        {
            return View();
        }
        public IActionResult RemoveToShoppingCart(int ProductIdForCart)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var x = _databaseContext.AddToCarts.Where(a => a.ProductId == ProductIdForCart).Select(a => a.Id).FirstOrDefault();
            var count = _databaseContext.AddToCarts.Where(a => a.UserId == userId).Count();
            var y = _databaseContext.AddToCarts.Find(x);
            _databaseContext.AddToCarts.Remove(y);
            _databaseContext.SaveChanges();

            if (count == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("AddToCarts", "ShoppingCart");
        }
        public IActionResult AddToCarts()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _cartItems.GetProducts(userId);
            return View(items);
        }
    }
}


