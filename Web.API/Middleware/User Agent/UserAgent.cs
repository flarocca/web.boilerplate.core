using System;
namespace Web.TORCHx.Core.Web.API
{
	public class UserAgent
	{
		public UserAgent(string app, string appVersion, string os, string osVersion, string device)
		{
			App = app;
			AppVersion = appVersion;
			OS = os;
			OSVersion = osVersion;
			Device = device;
		}

		public string App { get; set; }
		public string AppVersion { get; set; }
		public string OS { get; set; }
		public string OSVersion { get; set; }
		public string Device { get; set; }
	}
}
