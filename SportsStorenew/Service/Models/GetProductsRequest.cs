﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service.Models
{
    public class GetProductsRequest
    {
        
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string CategoryName { get;  set; }
        public string Description { get;  set; }
        public string Name { get;  set; }
        
    }
}
