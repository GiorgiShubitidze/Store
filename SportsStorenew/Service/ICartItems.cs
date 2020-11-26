using SportsStorenew.Service.Models;
using SportsStoreNew.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service
{
    public interface ICartItems
    {
        //public GetCategoriesResponse GetCategories(GetCategoriesRequest request);
        //public GetProductsReasponse GetProducts(GetProductsRequest request);
        // public GetProductDetails GetProduct(int Id);
        public GetProductAddToCart GetProducts(string userId);

    }
}
