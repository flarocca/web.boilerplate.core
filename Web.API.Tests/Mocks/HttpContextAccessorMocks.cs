using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Web.TORCHx.Core.Web.API.Tests
{
	public static class HttpContextAccessorMocks
	{
		public static IHttpContextAccessor MockReturningUserId(Guid userId)
		{
			//Create a claim
			var claim = new Claim(ClaimTypes.NameIdentifier, userId.ToString());

			//Create an identity with the claim
			var identity = new ClaimsIdentity(new Claim[] { claim }, nameof(Claim));
			identity.AddClaim(claim);

			//Create a principal with the identity
			var principal = new ClaimsPrincipal();
			principal.AddIdentity(identity);

			//Create a context with the principal
			var context = new DefaultHttpContext();
			context.User = principal;

			//Create a mock with the context
			var mock = new Mock<IHttpContextAccessor>();
			mock.Setup(x => x.HttpContext).Returns(context);

			return mock.Object;
		}
	}
}
