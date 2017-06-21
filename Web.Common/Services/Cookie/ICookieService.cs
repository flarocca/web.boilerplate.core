using Microsoft.AspNetCore.Builder;

namespace Web.TORCHx.Core.Web.Common
{
	public interface ICookieService
	{
		string CookieName();
		CookieAuthenticationOptions CookieAuthenticationOptions();
	}
}
