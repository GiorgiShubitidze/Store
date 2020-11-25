using Microsoft.AspNetCore.Mvc;
using SportsStoreCatalog.Domain;
using SportsStoreCatalog.Domain.DB;
using SportsStoreCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreCatalog.ViewComponents
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
