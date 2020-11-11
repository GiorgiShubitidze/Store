using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Domain;
using SportsStorenew.Domain.DB;
using SportsStorenew.Models;
using SportsStorenew.Service;

namespace SportsStorenew.Controllers
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

        
        public IActionResult AddToShoppingCart(int ProductId,int CategoryId)
        {
            var Cart = new AddToCart { DateTime = localDate, CartsProductId = ProductId };
            _databaseContext.AddToCarts.Add(Cart);
            _databaseContext.SaveChanges();
            var Category = _databaseContext.Categories.Where(a => a.CategoryId == CategoryId).Select(a => a.Name).FirstOrDefault();
            return RedirectToAction("Index","Home",new { categoryName = Category});
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
         [HttpPost]
        public IActionResult Checkout(CheckoutViewModel model)
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
        public IActionResult SuccessCheck()
        {
            return View();
        }




        public IActionResult RemoveToShoppingCart(int ProductIdForCart)
        {
            var x = _databaseContext.AddToCarts.Where(a => a.CartsProductId == ProductIdForCart).Select(a => a.Id).FirstOrDefault();
            var count = _databaseContext.AddToCarts.Where(a => a.CartsProductId > 0).Count();
            var y = _databaseContext.AddToCarts.Find(x);
            _databaseContext.AddToCarts.Remove(y);
            _databaseContext.SaveChanges();
           
            if(count ==1)
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
               
                foreach (var cart in Db.AddToCarts.ToList())
                {
                    var _shoppingCart = new ShoppingCart();
                    _shoppingCart.TotalCostForCart = Db.Products.Where(a => a.ProductId == cart.CartsProductId).Select(a => a.Price).FirstOrDefault();
                     _shoppingCart.NameForCart = Db.Products.Where(a => a.ProductId == cart.CartsProductId).Select(a => a.Name).FirstOrDefault();
                    _shoppingCart.DescriptionForCart = Db.Products.Where(a => a.ProductId == cart.CartsProductId).Select(a => a.Description).FirstOrDefault();
                    _shoppingCart.ImageUrlForCart = Db.ProductImages.Where(a => a.ProductId == cart.CartsProductId).Select(a => a.ImageUrl).FirstOrDefault();
                    _shoppingCart.ProductIdForCart = Db.ProductImages.Where(a => a.ProductId == cart.CartsProductId).Select(a => a.ProductId).FirstOrDefault();
                    _shoppingCart.Name = Db.Products.Where(a => a.ProductId == cart.CartsProductId).Select(a => a.Name).FirstOrDefault();
                    shoppingCart.Add(_shoppingCart);  
                }
               
                return View(shoppingCart);
            }


        }



    }
}
