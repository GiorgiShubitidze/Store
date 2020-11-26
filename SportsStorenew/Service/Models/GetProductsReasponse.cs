using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service.Models
{
    public class GetProductsReasponse
    {
        public IEnumerable<Product> Products { get;  set; }
        public int PageSize { get;  set; }
        public int Page { get;  set; }
        public int TotalCount { get;  set; }
        public string ProductDescription { get; set; }
        public string CategoryName { get;  set; }
        public string ProductName { get; set; }

        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string  ThumbnailUrl { get; set; }
            public int CategoryId { get; set; }
            public int DiscountPrice { get;  set; }
        }
    }
}
