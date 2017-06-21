using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Web.TORCHx.Core.Web.API
{
	/// <summary>
	/// Helper class to allow custom middleware to write JSON objects to an HTTP response
	/// so that formatting can be centralized.
	/// </summary>
	public class JsonWriter : IJsonWriter
	{
		private readonly JsonOutputFormatter _formatter;

		public JsonWriter(JsonOutputFormatter formatter)
		{
			_formatter = formatter;
		}

		public async Task WriteObject(HttpContext context, object obj, HttpStatusCode code)
		{
			var output = JsonConvert.SerializeObject(obj, _formatter.PublicSerializerSettings);
			context.Response.StatusCode = (int)code;
			context.Response.Headers.Add(HeaderNames.ContentType, "application/json");
			await context.Response.WriteAsync(output);
		}
	}
}
