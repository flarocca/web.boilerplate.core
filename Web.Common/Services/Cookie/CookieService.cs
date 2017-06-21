using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace Web.TORCHx.Core.Web.Common
{
	public class CookieService : ICookieService
	{
		IOptions<CookieServiceOptions> _options;
		ITokenService _tokenService;

		public CookieService(IOptions<CookieServiceOptions> options, ITokenService tokenService)
		{
			//TODO: validate options
			_options = options;
			_tokenService = tokenService;
		}

		public string CookieName()
		{
			return _options.Value.CookieName;
		}

		public CookieAuthenticationOptions CookieAuthenticationOptions()
		{
			return new CookieAuthenticationOptions {
				AutomaticAuthenticate = true,
				AutomaticChallenge = true,
				LoginPath = string.Empty,
				LogoutPath = string.Empty,
				AccessDeniedPath = string.Empty,
				CookieName = CookieName(),
				TicketDataFormat = CookieDataFormat(),
				Events = CookieAuthenticationEvents()
			};
		}

		/// <summary>
		/// Overrides the default redirect behavior so that 401 and 403 is returned instead of 404.
		/// </summary>
		/// <returns>The authentication events.</returns>
		public CookieAuthenticationEvents CookieAuthenticationEvents()
		{
			return new CookieAuthenticationEvents {
				OnRedirectToLogin = context => {
					context.Response.StatusCode = 401;
					return Task.FromResult(0);
				},
				OnRedirectToAccessDenied = context => {
					context.Response.StatusCode = 403;
					return Task.FromResult(0);
				}
			};
		}

		private ISecureDataFormat<AuthenticationTicket> CookieDataFormat()
		{
			return new CookieDataFormat(
				_tokenService.SigningAlgorithm(),
				_tokenService.TokenValidationParameters()
			);
		}
	}
}
