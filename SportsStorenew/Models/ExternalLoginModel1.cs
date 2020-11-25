using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SportsStorenew.Models
{
    public class ExternalLoginModel1
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ClaimsPrincipal Principal { get; set; }
    }
}
