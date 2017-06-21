using Newtonsoft.Json;

namespace Web.TORCHx.Core.Web.API
{
	public class SuccessResponse : BaseResponse
	{
		const string status = "success";

		public object Data { get; private set; }

		public SuccessResponse() : base(status)
		{
		}

		public SuccessResponse(object data) : this()
		{
			Data = data;
		}
	}
}
