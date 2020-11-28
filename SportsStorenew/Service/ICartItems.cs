using SportsStoreNew.Service.Models;
using SportsStoreNew.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service
{
    public interface ICartItems
    {
        public GetProductAddToCart GetProducts(string userId);
        public string  Add(int ProductId, int CategoryId ,string userName,string userId);
        public bool Remove(int ProductId,string userId);
        public ShoppingCartViewModel Count(string userName);
            
    }
}
