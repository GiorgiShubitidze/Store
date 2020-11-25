using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Domain
{
    public class AddToCart
    {
      
       
        public DateTime DateTime { get; set; }
        public string UserId { get; set;}
        public string UserName { get; set; }
        public IdentityUser User { get; set; }
        public int ProductId { get; set; }
       // public int CartsProductId { get; set; }
        public Product product { get; set; }
        public int Id { get; set; } 
    }
}
