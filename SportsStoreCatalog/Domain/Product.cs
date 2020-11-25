using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreCatalog.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public String Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; internal set; }
        public ICollection<ProductImage> Images { get; set; }
        public string Description { get; set; }
    }
}
