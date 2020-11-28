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
        ICheckDataService _ichekdataservice;
        ICartItems _cartItems;
        public ShoppingCartController( ICheckDataService ichekdataservice, ICartItems cartItems )
        {
            _ichekdataservice = ichekdataservice;
            _cartItems = cartItems;
        }
        DateTime localDate = DateTime.Now;
        // private ShoppingCart _shoppingCart;
        //private ShoppingCart _shoppingCart;
        
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
                var Check = _ichekdataservice.Check(model);
                if (Check == true)
                {
                    return RedirectToAction("SuccessCheck", "ShoppingCart");
                }
                else return View();
            }
            return View();
        }
        public IActionResult SuccessCheck()
        {
            return View();
        }
       
        public IActionResult AddToCarts()  //CartItems
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _cartItems.GetProducts(userId);
            return View(items);
        }
        public IActionResult AddToShoppingCart(int ProductId, int CategoryId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.Identity.Name;
            var Add = _cartItems.Add(ProductId, CategoryId, userName, userId);//return Category 
            return RedirectToAction("Index", "Home", new { categoryName = Add });
        }
        public IActionResult RemoveToShoppingCart(int ProductIdForCart)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Remove = _cartItems.Remove(ProductIdForCart, userId);
            if (Remove == true)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("AddToCarts", "ShoppingCart");
        }
    }
}


