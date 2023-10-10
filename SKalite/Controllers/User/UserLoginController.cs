using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SKalite.Entity.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SKalite
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly IUserService _UserService;
        public UserLoginController(IOptions<JwtSettings> jwtsettings)
        {
            _jwtSettings = jwtsettings.Value;
        }

        [HttpPost]
        public IActionResult LoginControl([FromBody] User user)
        {
            var ApiUser = UserAutControl(user);
            if (ApiUser == null) { return NotFound("Kullanıcı Bulunamadı"); }

            else
            {
                var token = CreateToken(user);
                return Ok(token); 
            }
        }

        private string CreateToken(User user)
        {
            if(_jwtSettings.Key == null ) throw new Exception("Hata");
            var securtiyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var credentials = new SigningCredentials(securtiyKey,SecurityAlgorithms.HmacSha256);
            var claimArray = new []
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.Name),
                new Claim(ClaimTypes.Surname, user.Surname),
                new Claim(ClaimTypes.Email,user.EMail)
            };
             var token = new JwtSecurityToken(_jwtSettings.Issuer,_jwtSettings.Audience,
                 claimArray,expires:DateTime.Now.AddHours(1),signingCredentials:credentials);

            return new JwtSecurityTokenHandler().WriteToken(token); 

        }

        private User? UserAutControl(User user)
        {
            return _UserService.GetByUserControl(user.TCKNumber,user.Password); 
        }
    }
}
