using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Domain;
using SportsStorenew.Domain.DB;
using SportsStorenew.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.ViewComponents
{
    
    public class ShoppingCartSummary : ViewComponent
    {
        
        public async Task <IViewComponentResult> InvokeAsync()
        {

            using (var Db = new SportsStoreDbContext())
            {
                var carts = Db.AddToCarts.Select(a => a.CartsProductId).Count();

                var shoppingCartViewModel = new ShoppingCartViewModel
                {
                    ShoppingCartTotal = carts
                };

                return await Task.FromResult(View(shoppingCartViewModel));
            }
        }

    }
}
