using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service.Models
{
    interface ICheckDataService
    {
        public GetProductAddToCart GetCategories(GetCategoriesRequest request);
        public GetProductsReasponse GetProducts(GetProductsRequest request);
    }
}
