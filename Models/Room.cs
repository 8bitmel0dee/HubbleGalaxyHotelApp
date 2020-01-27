using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HubbleGalaxyHotelApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double PricePerNight { get; set; }

        public string RoomDescription { get; set; }
        public string RoomFeatures { get; set; }

        [Display(Name = "Room Image")]
        public string RoomImage { get; set; }


        public string UserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
