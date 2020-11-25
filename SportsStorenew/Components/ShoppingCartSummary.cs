using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace SportsStoreNew.ViewComponents
{
   
    public class ShoppingCartSummary : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userName = User.Identity.Name;
            
            using (var Db = new SportsStoreDbContext())
            {
                var carts = 0;
                if (userName != null)
                {
                    carts = Db.AddToCarts.Where(a => a.UserName == userName).Select(a => a.ProductId).Count();
                }

                var shoppingCartViewModel = new ShoppingCartViewModel
                {
                    ShoppingCartTotal = carts
                };
                return await Task.FromResult(View(shoppingCartViewModel));
            }
        }

    }
}
