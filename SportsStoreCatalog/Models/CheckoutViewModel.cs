using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreCatalog.Models
{
    public class CheckoutViewModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required")]
        //[DisplayName("First Name")]
        [StringLength(160)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        //[DisplayName("Last Name")]
        [StringLength(160)]
        public string Surname { get; set; }

        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        //    ErrorMessage = "Email is is not valid.")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(70)]
        public string Address { get; set; }

        [StringLength(400)]
        public string Note { get; set; }


    }
}
