using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Web.TORCHx.Core.BLL.Membership;
using Web.TORCHx.Core.Web.Common;

namespace Web.TORCHx.Core.Web.API
{
	public class UserController : BaseController
    {
		private readonly HttpContext _httpContext;
		private readonly IUserService _userService;

		public UserController(IHttpContextAccessor contextAccessor, IUserService userService)
		{
			_httpContext = contextAccessor?.HttpContext;
			_userService = userService;
		}

		// GET api/v1/user
		[Authorize]
		public IActionResult GetCurrentUser()
		{
			var userId = _httpContext.User.GetUserId();
			return GetUserById(userId);
		}

		// GET api/v1/user/{id}
		[HttpGet("{id}")]
		[Authorize]
		public IActionResult GetUserById(Guid id)
		{
			var user = _userService.GetUser(id);
			return new SuccessResult(user);
		}
    }
}
