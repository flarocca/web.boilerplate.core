using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Web.TORCHx.Core.Web.API
{
	public class ErrorMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly IHostingEnvironment _environment;
		private readonly IJsonWriter _jsonWriter;

		public ErrorMiddleware(RequestDelegate next, IHostingEnvironment environment, IJsonWriter jsonWriter)
		{
			_next = next;
			_environment = environment;
			_jsonWriter = jsonWriter;
		}

		public async Task Invoke(HttpContext context, JsonOutputFormatter formatter)
		{
			try {
				await _next(context);
			} catch (Exception e) {

				ErrorResponse response;
				HttpStatusCode code = HttpStatusCode.InternalServerError;

				//Only return exception details if in development
				if (_environment.IsDevelopment()) {
					response = new ErrorResponse(e);
				} else {
					response = new ErrorResponse(code);
				}

				await _jsonWriter.WriteObject(context, response, code);
			}
		}
	}
}
