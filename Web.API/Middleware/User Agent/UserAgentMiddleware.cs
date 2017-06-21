using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;

namespace Web.TORCHx.Core.Web.API
{
	/// <summary>
	/// User-Agent: TORCHx/1.0.0 (iOS 10.0.2; iPad6,3)
	/// Allows the API to return a custom response based on user agent.
	/// </summary>
	public class UserAgentMiddleware
	{
		private const string _header = "User-Agent";
		private const string _pattern = "(.*)\\/(.*) \\((.*) (.*); (.*)\\)";
		private readonly RequestDelegate _next;
		private readonly IJsonWriter _jsonWriter;

		public UserAgentMiddleware(RequestDelegate next, IJsonWriter jsonWriter)
		{
			_next = next;
			_jsonWriter = jsonWriter;
		}

		public async Task Invoke(HttpContext context)
		{
			string header = context.Request.Headers[_header];
			var userAgent = GetUserAgent(header);

			if (userAgent == null) {
				var response = new FailureResponse(_header, "Missing or invalid value.");
				await _jsonWriter.WriteObject(context, response, HttpStatusCode.BadRequest);
				return;
			}

			await _next(context);
		}

		private UserAgent GetUserAgent(string input)
		{
			Regex regex = new Regex(_pattern);
			Match match = regex.Match(input);

			if (!match.Success) {
				return null;
			}
			if (match.Groups.Count < 6) {
				return null;
			}

			return new UserAgent(
				match.Groups[1].Value,
				match.Groups[2].Value,
				match.Groups[3].Value,
				match.Groups[4].Value,
				match.Groups[5].Value
			);
		}
	}
}
