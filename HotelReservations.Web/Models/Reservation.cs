﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Web.Models
{
	public class Reservation
	{
		[DisplayName("Start Date")]
		[DataType(DataType.Text)]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Use numbers only please")]
		[Required]
		public int StartDate { get; set; }

		[DisplayName("End Date")]
		[DataType(DataType.Text)]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "Use numbers only please")]
		[Required]
		public int EndDate { get; set; }

		public bool Accepted { get; set; }
	}
}