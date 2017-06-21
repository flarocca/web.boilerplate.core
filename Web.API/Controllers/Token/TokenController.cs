using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.TORCHx.Core.BLL.Membership;
using Web.TORCHx.Core.Web.Common;

namespace Web.TORCHx.Core.Web.API
{
	public class TokenController : BaseController
	{
		private readonly IUserService _userService;
		private readonly ITokenService _tokenService;
		private readonly HttpContext _httpContext;

		public TokenController(IHttpContextAccessor contextAccessor, IUserService userService, ITokenService tokenService)
		{
			_httpContext = contextAccessor?.HttpContext;
			_userService = userService;
			_tokenService = tokenService;
		}

		/// <summary>
		/// GET api/v1/token
		/// Refreshes a token for an authenticated user.
		/// </summary>
		/// <returns>The new token.</returns>
		[HttpGet]
		[Authorize]
		public IActionResult Get()
		{
			var userId = _httpContext.User.GetUserId();
			var token = _tokenService.GenerateToken(userId);
			if (token == null) {
				return new FailureResult(HttpStatusCode.Unauthorized);
			}

			return new SuccessResult(token);
		}

		/// <summary>
		/// POST api/v1/token
		/// Generates a token for an unauthenticated user.
		/// </summary>
		/// <returns>The token.</returns>
		/// <param name="tokenRequest">Token request.</param>
		[HttpPost]
		[ValidateModel]
		public IActionResult Post([FromBody] TokenRequest tokenRequest)
		{
			var isValid = _userService.ValidateUser(tokenRequest.Username, tokenRequest.Password);
			if (!isValid) {
				return new FailureResult(HttpStatusCode.Unauthorized);
			}

			var user = _userService.GetUser(tokenRequest.Username);
			if (user == null) {
				return new FailureResult(HttpStatusCode.Unauthorized);
			}

			var token = _tokenService.GenerateToken(user.UserId);
			if (token == null) {
				return new FailureResult(HttpStatusCode.Unauthorized);
			}

			return new SuccessResult(token);
		}
	}
}
