using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Web.TORCHx.Core.Web.API
{
	public class FailureResult : ObjectResult
	{
		public FailureResult(Failure error) : base(new FailureResponse(error))
		{
			StatusCode = (int)HttpStatusCode.BadRequest;
		}

		public FailureResult(IEnumerable<Failure> errors) : base(new FailureResponse(errors))
		{
			StatusCode = (int)HttpStatusCode.BadRequest;
		}

		public FailureResult(HttpStatusCode code) : base(new FailureResponse(new Failure(code)))
		{
			StatusCode = (int)code;
		}
	}
}
