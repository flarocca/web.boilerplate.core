using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.TORCHx.Core.Web.API
{
	public class SuccessResult : OkObjectResult
	{
		public SuccessResult(object _object) : base(new SuccessResponse(_object))
		{
		}
	}
}
