using Core.Entities;
using System;

namespace Entities.DTOs
{
	public class CarRentalDetailsDto : IDto
	{

		public int Id { get; set; }
		public int CarId { get; set; }
		public string BrandName { get; set; }
		public string ColorName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CompanyName { get; set; }
		public int CarModelYear { get; set; }
		public decimal CarDailyPrice { get; set; }
		public string CarDescription { get; set; }
		public DateTime RentDate { get; set; }
		public DateTime? ReturnDate { get; set; }

	}
}
