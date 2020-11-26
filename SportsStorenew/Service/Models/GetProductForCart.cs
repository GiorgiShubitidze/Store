using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.Service.Models
{
    public class GetProductForCart
    {
        public string DescriptionForCart { get; set; }
        public decimal TotalCostForCart { get; set; }

        public string NameForCart { get; set; }
        public string ImageUrlForCart { get; set; }
        public int ProductIdForCart { get; set; }
        public string Name { get; set; }
        public int CountForCart { get; set; }
    }
}
