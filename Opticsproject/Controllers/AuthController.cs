using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DAL.Dtos;

namespace Opticsproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly string _secretKey = "yourSecretKey"; // החליפי ב-secret key שלך
        private readonly string _issuer = "yourIssuer"; // החליפי ב-issuer שלך
        private readonly string _audience = "yourAudience"; // החליפי ב-audience שלך

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            // כאן את יכולה להוסיף את הלוגיקה שלך לבדוק אם המשתמש מאומת
            // נניח שהמשתמש מאומת בהצלחה, ניצור JWT
            var token = GenerateToken("userId"); // החליפי ב-userId נכון
            return Ok(new { Token = token });
        }

        private string GenerateToken(string userId)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

}
