using System;
using System.Security.Claims;

namespace Web.TORCHx.Core.Web.Common
{
    public static class ClaimsPrincipalExtensions
    {
        public static Guid GetUserId(this ClaimsPrincipal user)
        {
			var userId = user.FindFirst(ClaimTypes.NameIdentifier).Value;
			return new Guid(userId);
        }
    }
}
