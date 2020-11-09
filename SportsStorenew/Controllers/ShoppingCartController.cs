using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Domain;
using SportsStorenew.Domain.DB;

namespace SportsStorenew.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ShoppingCartController : ControllerBase
    {

        SportsStoreDbContext _databaseContext;


        public ShoppingCartController(SportsStoreDbContext Db)
        {
            _databaseContext = Db;
        }
        DateTime localDate = DateTime.Now;


        public RedirectToActionResult AddToShoppingCart(int ProductId)
        {
            var Cart = new AddToCart { DateTime = localDate, CartsProductId = ProductId };
            _databaseContext.AddToCarts.Add(Cart);
            _databaseContext.SaveChanges();

            return RedirectToAction("Index","Home");
        }
    }
}
