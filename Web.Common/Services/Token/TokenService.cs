using System;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Web.TORCHx.Core.Web.Common
{
    public class TokenService : ITokenService
    {
        private readonly IOptions<TokenServiceOptions> _options;

        public TokenService(IOptions<TokenServiceOptions> options)
        {
			//TODO: validate options
			_options = options;
        }

        public JwtBearerOptions JwtBearerOptions()
        {
            return new JwtBearerOptions {
                AutomaticAuthenticate = true,
                TokenValidationParameters = TokenValidationParameters()
            };
        }

        public string GenerateToken(Guid userId)
        {
			var jwt = GetJwt(userId);
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        public string SigningAlgorithm()
        {
            return SecurityAlgorithms.HmacSha256;
        }

        public TokenValidationParameters TokenValidationParameters()
        {
            return new TokenValidationParameters {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = SecurityKey(),
                ValidateIssuer = true,
                ValidIssuer = _options.Value.Issuer,
                ValidateAudience = true,
                ValidAudience = _options.Value.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };
        }

		private SymmetricSecurityKey SecurityKey()
		{
			return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_options.Value.SigningKey));
		}

		private SigningCredentials SigningCredentials()
		{
			return new SigningCredentials(SecurityKey(), SigningAlgorithm());
		}

		private TimeSpan Expiration()
		{
			return TimeSpan.FromMinutes(_options.Value.Expiration);
		}

        private JwtSecurityToken GetJwt(Guid userId)
        {
            var now = DateTime.UtcNow;
            var claims = new Claim[] {
				new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, new DateTimeOffset(now).ToUniversalTime().ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            };

            return new JwtSecurityToken(
                issuer: _options.Value.Issuer,
                audience: _options.Value.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(Expiration()),
                signingCredentials: SigningCredentials()
            );
        }
    }
}
