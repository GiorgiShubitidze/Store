using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using SportsStoreNew.Service;

namespace SportsStoreNew.ViewComponents
{

    public class ShoppingCartSummary : ViewComponent
    {
        ICartItems _cartItems;
        public ShoppingCartSummary(ICartItems cartItems)
        {
            this._cartItems = cartItems;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userName = User.Identity.Name;
            var Count = _cartItems.Count(userName);
            return await Task.FromResult(View(Count));
        }

    }
}
