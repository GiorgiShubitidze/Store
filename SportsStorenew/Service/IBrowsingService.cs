using SportsStoreNew.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service
{
    public interface IBrowsingAppService
    {
        public GetCategoriesResponse GetCategories(GetCategoriesRequest request);
        public GetProductsReasponse GetProducts(GetProductsRequest request);
    }

}
