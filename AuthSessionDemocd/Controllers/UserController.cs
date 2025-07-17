using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using AuthSessionDemocd.Models;


namespace AuthSessionDemocd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        public static List<Users> users = new List<Users>();

        [HttpPost("register")]
        public IActionResult Register(Users newUser)
        {
            if (users.Any(u => u.Email == newUser.Email))
                return BadRequest("User already exists.");

            users.Add(newUser);
            return Ok("Signup successful."); 
        }

        [HttpPost("login")]
        public IActionResult Login(Users user)
        {
            var existingUser = users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (existingUser == null)
                return BadRequest("Invalid credentials.");

           HttpContext.Session.SetString("email", existingUser.Email);
           HttpContext.Session.SetString("password", existingUser.Password);
           HttpContext.Session.SetString("role", existingUser.Role);

           return Ok(new { role = existingUser.Role });
        }

        [HttpGet("check-session")]
        public IActionResult CheckSession()
        {
            var name = HttpContext.Session.GetString("name");
            var email = HttpContext.Session.GetString("email");
            var role = HttpContext.Session.GetString("role");

            if (name == null || email == null || role == null)
                return Unauthorized("Session expired. Please login again.");

            return Ok(new { name = name, email = email, role = role });
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Ok("Logged out");
        }
    }
}