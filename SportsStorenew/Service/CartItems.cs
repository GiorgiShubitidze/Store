using SportsStorenew.Service.Models;
using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service.Models;
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

        public GetProductAddToCart GetProducts(String userId)
        {

            using (var Db = new SportsStoreDbContext())
            {
                var shoppingCart = new List<ShoppingCart>();

                foreach (var cart in Db.AddToCarts.ToList())
                {
                    if (userId == cart.UserId)
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
                return new GetProductAddToCart { Product = shoppingCart };
            }
        }
    }
}
