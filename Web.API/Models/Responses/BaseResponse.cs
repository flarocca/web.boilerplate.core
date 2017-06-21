using System;
namespace Web.TORCHx.Core.Web.API
{
	/// <summary>
	/// This follows the JSend specification.
	/// https://labs.omniti.com/labs/jsend
	/// </summary>
	public class BaseResponse
	{
		public string Status { get; private set; }

		public BaseResponse(string status)
		{
			Status = status;
		}
	}
}
