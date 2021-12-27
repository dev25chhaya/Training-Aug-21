
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StaySafeHotels.Authentication;
using StaySafeHotels.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ICustomer customers;
        private readonly IAdmin admins;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> userManager;

        public AuthenticationController(ICustomer customer, IAdmin admin, IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            customers = customer;
            admins = admin;
            _configuration = configuration;
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var username = "";
            var pass = "";
            var role = "";

            if (customers.FindName(model.UserName) != null)
            {
                username = model.UserName;
                pass = model.Password;
                role = "User";

                

            }
            else if (admins.FindName(model.UserName) != null)
            {
                username = model.UserName;
                //pass = admins.FindName(model.Username).Password;
                pass = model.Password;
                role = "Admin";

            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Incorrect Username or Password!" });
            }

            var newToken = await customers.LoginUser(username, pass);

                return Ok(new
                {
                    role = role,
                    username = username,
                    token = newToken
                });
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (customers.FindName(model.Username) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            }

            if (customers.FindContact(model.PhoneNumber) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Contact No. already exists!" });
            }

            var result = await customers.RegisterUser(model);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            //users.CreateUser(model);

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });

        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            if (admins.FindName(model.Username) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Admin already exists!" });
            }

            if (admins.FindContact(model.PhoneNumber) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Contact no. already exists!" });
            }

            var result = await admins.RegisterAdmin(model);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Admin creation failed! Please check admin details and try again." });

            //admins.CreateAdmin(model);

            return Ok(new Response { Status = "Success", Message = "Admin created successfully!" });
        }
    }
}
