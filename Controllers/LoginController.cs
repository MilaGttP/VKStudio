using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VKStudio.Models;
using VKStudio.Services;

namespace VKStudio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            try
            {
                if (_authService.IsValidUser(loginRequest.Login, loginRequest.Password))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, loginRequest.Login),
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return Ok(new { success = true });
                }

                return BadRequest(new { success = false });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false });
            }
        }
    }
}
