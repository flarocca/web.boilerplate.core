﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Web.TORCHx.Core.Web.MVC
{
	public class LoginRequest
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }
	}
}
