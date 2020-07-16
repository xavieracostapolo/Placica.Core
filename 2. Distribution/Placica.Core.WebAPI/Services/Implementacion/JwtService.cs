using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Placica.Core.WebAPI.Services.Implementacion
{
    public class JwtService
    {
        private readonly string _secret;
        private readonly string _expDate;
        private readonly string _validIssuer;
        private readonly string _validAudience;

        public JwtService(IConfiguration config)
        {
            _secret = config.GetSection("JwtConfig").GetSection("secret").Value;
            _expDate = config.GetSection("JwtConfig").GetSection("expirationInMinutes").Value;
            _validIssuer = config.GetSection("JwtConfig").GetSection("validIssuer").Value;
            _validAudience = config.GetSection("JwtConfig").GetSection("validAudience").Value;
        }

        public string GenerateSecurityToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);

            var defineExpireTime = DateTime.UtcNow.AddMinutes(double.Parse(_expDate));
            var userId = 7687686;

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Name, email),
                    new Claim(ClaimTypes.Role, email),
                    new Claim(ClaimTypes.Expiration, email),
                    new Claim(JwtRegisteredClaimNames.NameId, userId.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Nbf, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff")),
                    new Claim(JwtRegisteredClaimNames.Exp, defineExpireTime.ToString("yyyy-MM-dd HH:mm:ss.ffff")),
                    new Claim("Anything", "Custom claim, additional data needed..."),
                    new Claim("Anything2", "more detail..."),
                }),
                Expires = defineExpireTime,
                Issuer = _validIssuer,
                Audience = _validIssuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }
    }
}