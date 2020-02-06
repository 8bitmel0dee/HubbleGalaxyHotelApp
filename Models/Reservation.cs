using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HubbleGalaxyHotelApp.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		
		public Room Room { get; set; }
		
		public int RoomId { get; set; }

		[Required]
		[Display(Name = "Select Payment Type")]
		public int PaymentTypeId { get; set; }


		public ApplicationUser ApplicationUser { get; set; }
		public string UserId { get; set; }

		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }

		[Display(Name = "End Date")]
		public DateTime EndDate { get; set; }

		
	}
}
