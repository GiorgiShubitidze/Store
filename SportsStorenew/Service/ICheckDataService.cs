using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.Service.Models
{
    interface ICheckDataService
    {
        public GetProductAddToCart GetCategories(GetCategoriesRequest request);
        public GetProductsReasponse GetProducts(GetProductsRequest request);
    }
}
