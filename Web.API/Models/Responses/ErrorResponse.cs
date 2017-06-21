using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace Web.TORCHx.Core.Web.API
{
	public class ErrorResponse : BaseResponse
	{
		const string status = "error";

		public object Data { get; private set; }

		public string Message { get; private set; }

		public ErrorResponse(string message) : base(status)
		{
			Message = message;
		}

		public ErrorResponse(Exception exception) : this(exception?.Message)
		{
			Data = exception?.StackTrace;
		}

		public ErrorResponse(HttpStatusCode code) : this(code.ToString())
		{
		}
	}
}
