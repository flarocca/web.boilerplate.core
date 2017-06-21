using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Web.TORCHx.Core.Web.API
{
	public class ErrorResult : ObjectResult
	{
		public ErrorResult(Exception exception) : base(new ErrorResponse(exception))
		{
			StatusCode = (int)HttpStatusCode.InternalServerError;
		}

		public ErrorResult() : this(null)
		{
			StatusCode = (int)HttpStatusCode.InternalServerError;
		}
	}
}
