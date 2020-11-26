using System.Collections.Generic;

namespace SportsStoreNew.Service.Models
{
    public class GetProductAddToCart
    {

        public IEnumerable<ShoppingCart> Product { get; set; }

    }
}