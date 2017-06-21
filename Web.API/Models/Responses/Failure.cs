using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Web.TORCHx.Core.BLL;

namespace Web.TORCHx.Core.Web.API
{
	public class Failure : Dictionary<string, string>
	{
		public Failure(string key, string value)
		{
			this[key] = value;
		}

		public Failure(HttpStatusCode code) : this(((int)code).ToString(), code.ToString().SplitCamelCase())
		{
		}
	}
}
