using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubbleGalaxyHotelApp.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string NameOfAccount { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string UserId { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
