using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.TORCHx.Core.Web.API
{
	public class TokenRequest : IValidatableObject
	{
		[Required]
		[EmailAddress]
		[StringLength(100)]
		public string Username { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 4)]
		public string Password { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			//yield return new ValidationResult("some problem", new string[]{"some key"});
			return new ValidationResult[] {};
		}
	}
}
