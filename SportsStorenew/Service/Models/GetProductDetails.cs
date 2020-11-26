using SportsStoreNew.Domain;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service.Models
{
    public class GetProductDetails
    {
        public string DetailsImageUrl { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
    }
}
