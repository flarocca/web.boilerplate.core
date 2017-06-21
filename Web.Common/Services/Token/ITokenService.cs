using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;

namespace Web.TORCHx.Core.Web.Common
{
    public interface ITokenService
    {
		JwtBearerOptions JwtBearerOptions();
		string GenerateToken(Guid userId);
		string SigningAlgorithm();
		TokenValidationParameters TokenValidationParameters();
	}
}
