using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace Web.TORCHx.Core.Web.API
{
	public class FailureResponse : BaseResponse
	{
		const string status = "fail";

		public object Data { get; private set; }

		public FailureResponse() : base(status)
		{
		}

		public FailureResponse(IEnumerable<Failure> errors) : this()
		{
			Data = errors;
		}

		public FailureResponse(Failure error) : this(new Failure[] { error })
		{
		}

		public FailureResponse(HttpStatusCode code) : this(new Failure(code))
		{
		}

		public FailureResponse(string key, string value) : this(new Failure(key, value))
		{
		}
	}
}
