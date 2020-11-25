using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreCatalog.Domain
{
    public class ProductDetails
    {
        public string DetailsImageUrl { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }

    }
}
