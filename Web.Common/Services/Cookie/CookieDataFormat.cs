using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace Web.TORCHx.Core.Web.Common
{
	/// <summary>
	/// Used by the authentication middleware to validate a cookie. Just a wrapper around a JWT.
	/// </summary>
	public class CookieDataFormat : ISecureDataFormat<AuthenticationTicket>
    {
        private readonly string _algorithm;
        private readonly TokenValidationParameters _validationParameters;

        public CookieDataFormat(string algorithm, TokenValidationParameters validationParameters)
        {
            _algorithm = algorithm;
            _validationParameters = validationParameters;
        }

        public AuthenticationTicket Unprotect(string protectedText) => Unprotect(protectedText, null);

        public AuthenticationTicket Unprotect(string protectedText, string purpose)
        {
            var handler = new JwtSecurityTokenHandler();
            ClaimsPrincipal principal = null;
            SecurityToken validToken = null;

            try
            {
                principal = handler.ValidateToken(protectedText, _validationParameters, out validToken);
                var validJwt = validToken as JwtSecurityToken;

                if (validJwt == null) {
                    throw new ArgumentException("Invalid JWT");
                }

                if (!validJwt.Header.Alg.Equals(_algorithm, StringComparison.Ordinal)) {
                    throw new ArgumentException($"Algorithm must be '{_algorithm}'");
                }

            }
            catch (SecurityTokenValidationException)
            {
                return null;
            }
            catch (ArgumentException)
            {
                return null;
            }

            // Token validation passed
            return new AuthenticationTicket(principal, new AuthenticationProperties(), "Cookie");
        }

        public string Protect(AuthenticationTicket data)
        {
            throw new NotImplementedException();
        }

        public string Protect(AuthenticationTicket data, string purpose)
        {
            throw new NotImplementedException();
        }
    }
}
