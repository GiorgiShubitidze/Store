using SportsStorenew.Service.Models;
using SportsStoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service.Models
{
   public interface ICheckDataService
    {
        //public GetProductAddToCart GetCategories(GetCategoriesRequest request);
        //public GetProductsReasponse GetProducts(GetProductsRequest request);
        public bool Check(CheckoutViewModel model);
    }
}
