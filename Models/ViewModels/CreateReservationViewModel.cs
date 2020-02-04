using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace HubbleGalaxyHotelApp.Models.ViewModels
{
    public class CreateReservationViewModel
    {
            
            public List<SelectListItem> PaymentTypes { get; set; }

            public Reservation Reservation { get; set; }

            public Room Room { get; set; }


            
        
    }
}
