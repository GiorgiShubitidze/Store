using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreCatalog.Domain
{
    public class AddToCart
    {
      
        public int CartsProductId { get; set; }
        public DateTime DateTime { get; set; }
        public string UserId { get; set;}
        public IdentityUser User { get; set; }
        
        public int Id { get; set; } 
    }
}
