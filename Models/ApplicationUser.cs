using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HubbleGalaxyHotelApp.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }




        public List<PaymentType> PaymentTypes { get; set; } = new List<PaymentType>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();



    }
}
