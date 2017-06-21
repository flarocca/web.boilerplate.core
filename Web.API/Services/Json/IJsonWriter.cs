using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Web.TORCHx.Core.Web.API
{
	public interface IJsonWriter
	{
		Task WriteObject(HttpContext context, object obj, HttpStatusCode code);
	}
}
