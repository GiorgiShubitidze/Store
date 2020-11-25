using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Service;
using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Models;
using SportsStoreNew.Service;

namespace SportsStoreNew.Controllers
{
    public class ShoppingCartController : Controller
    {

        SportsStoreDbContext _databaseContext;


        public ShoppingCartController(SportsStoreDbContext Db)
        {
            _databaseContext = Db;
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
            var Cart = new AddToCart { DateTime = localDate, UserId=userId ,UserName=userName ,ProductId= ProductId };
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
                
                var Chackout = new CheckoutViewModel();
                Chackout.Address = model.Address;
                Chackout.Email = model.Email;
                Chackout.Name = model.Name;
                Chackout.Note = model.Note;
                Chackout.Surname = model.Surname;

                _databaseContext.CheckoutViewModels.Add(Chackout);
                _databaseContext.SaveChanges();
                return RedirectToAction("SuccessCheck", "ShoppingCart");
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
            var count = _databaseContext.AddToCarts.Where(a => a.UserId==userId).Count();
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

            using (var Db = new SportsStoreDbContext())
            {
                var shoppingCart = new List<ShoppingCart>();
                
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                foreach (var cart in Db.AddToCarts.ToList())
                {
                    if (userId==cart.UserId)
                    {
                        var _shoppingCart = new ShoppingCart();
                        _shoppingCart.TotalCostForCart = Db.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Price).FirstOrDefault();
                        _shoppingCart.NameForCart = Db.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Name).FirstOrDefault();
                        _shoppingCart.DescriptionForCart = Db.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Description).FirstOrDefault();
                        _shoppingCart.ImageUrlForCart = Db.ProductImages.Where(a => a.ProductId == cart.ProductId).Select(a => a.ImageUrl).FirstOrDefault();
                        _shoppingCart.ProductIdForCart = Db.ProductImages.Where(a => a.ProductId == cart.ProductId).Select(a => a.ProductId).FirstOrDefault();
                        _shoppingCart.Name = Db.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Name).FirstOrDefault();
                        shoppingCart.Add(_shoppingCart);
                    }
                    
                }
               

                return View(shoppingCart);
            }


        }



    }
}
