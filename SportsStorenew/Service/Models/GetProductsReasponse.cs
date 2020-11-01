﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.Service.Models
{
    public class GetProductsReasponse
    {
        public IEnumerable<Product> Products { get;  set; }

        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string  ThumbnailUrl { get; set; }
        }
    }
}
