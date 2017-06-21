using System;
using Web.TORCHx.Core.Web.Common;
using Moq;

namespace Web.TORCHx.Core.Web.API.Tests
{
    public static class TokenServiceMocks
    {
	    public static ITokenService MockReturningGenerateToken(string token)
	    {
	        var mock = new Mock<ITokenService>();
            mock.Setup(x => x.GenerateToken(It.IsAny<Guid>()))
			    .Returns(token);
	        return mock.Object;
	    }
    }
}