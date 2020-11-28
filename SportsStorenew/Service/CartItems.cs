using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service.Models;
using SportsStoreNew.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SportsStoreNew.Service
{
    public class CartItems : ICartItems
    {
        SportsStoreDbContext _dbContext;
        public CartItems(SportsStoreDbContext dbcontext)
        {
            this._dbContext = dbcontext;
        }
        DateTime localDate = DateTime.Now;
        public string Add(int ProductId, int CategoryId, string userName, string userId)
        {

            var Category = _dbContext.Categories.Where(a => a.CategoryId == CategoryId).Select(a => a.Name).FirstOrDefault();

            var Cart = new AddToCart { DateTime = localDate, UserId = userId, UserName = userName, ProductId = ProductId };
            _dbContext.AddToCarts.Add(Cart);
            _dbContext.SaveChanges();
            return Category;
        }

        public GetProductAddToCart GetProducts(String userId)
        {
            var shoppingCart = new List<ShoppingCart>();
            foreach (var cart in _dbContext.AddToCarts.ToList())
            {
                if (userId == cart.UserId)
                {
                    var _shoppingCart = new ShoppingCart();
                    _shoppingCart.TotalCostForCart = _dbContext.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Price).FirstOrDefault();
                    _shoppingCart.NameForCart = _dbContext.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Name).FirstOrDefault();
                    _shoppingCart.DescriptionForCart = _dbContext.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Description).FirstOrDefault();
                    _shoppingCart.ImageUrlForCart = _dbContext.ProductImages.Where(a => a.ProductId == cart.ProductId).Select(a => a.ImageUrl).FirstOrDefault();
                    _shoppingCart.ProductIdForCart = _dbContext.ProductImages.Where(a => a.ProductId == cart.ProductId).Select(a => a.ProductId).FirstOrDefault();
                    _shoppingCart.Name = _dbContext.Products.Where(a => a.ProductId == cart.ProductId).Select(a => a.Name).FirstOrDefault();
                    shoppingCart.Add(_shoppingCart);
                }
            }
            return new GetProductAddToCart { Product = shoppingCart };
        }

        public bool Remove(int ProductId, string userId)
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Id = _dbContext.AddToCarts.Where(a => a.ProductId == ProductId).Select(a => a.Id).FirstOrDefault();
            var count = _dbContext.AddToCarts.Where(a => a.UserId == userId).Count();
            var Find = _dbContext.AddToCarts.Find(Id);
            _dbContext.AddToCarts.Remove(Find);
            _dbContext.SaveChanges();

            if (count == 1)
            {
                return true;
            }
            return false;
        }

        public ShoppingCartViewModel Count(string userName)
        {
            var carts = 0;
            if (userName != null)
            {
                carts = _dbContext.AddToCarts.Where(a => a.UserName == userName).Select(a => a.ProductId).Count();
            }
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCartTotal = carts
            };
            return shoppingCartViewModel;
        }
    }
}
