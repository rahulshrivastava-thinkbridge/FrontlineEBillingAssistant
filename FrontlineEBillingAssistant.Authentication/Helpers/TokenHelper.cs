using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace FrontlineEBillingAssistant.Authentication.Helpers
{
    public class TokenHelper
    {
        public static string GenerateSecureSecret()
        {
            var hmac = new HMACSHA256();
            return Convert.ToBase64String(hmac.Key);
        }

        public static string GenerateToken(Core.Models.User user)
        {
            var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, "FrontlineServiceAccessToken"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.Id.ToString()),
                    new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("UserName", user.Login),
                    new Claim("Email", user.Email),
                    new Claim("IsActive", user.Status.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sdfsdfsjdbf78sdyfssdfsdfbuidfs98gdfsdbf"));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken("FrontlineAuthenticationServer", "FrontlineServiceClient", claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
