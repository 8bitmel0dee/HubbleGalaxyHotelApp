using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubbleGalaxyHotelApp.Models
{
	public class Reservation
	{
		public int Id { get; set; }

		public int RoomId { get; set; }
		public int PaymentTypeId { get; set; }

		public ApplicationUser ApplicationUser { get; set; }
		public string UserId { get; set; }


		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

	}
}
