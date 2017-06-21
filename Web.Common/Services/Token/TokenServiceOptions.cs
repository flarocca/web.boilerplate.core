using System;

namespace Web.TORCHx.Core.Web.Common
{
    public class TokenServiceOptions
    {
        public string SigningKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Expiration { get; set; }
    }
}
