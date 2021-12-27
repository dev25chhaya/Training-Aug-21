//using AutoMapper.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using StaySafeHotels.Authentication;
using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace StaySafeHotels.Repository
{
    public class CustomerRepository : GenericRepository<ApplicationUser>, ICustomer
    {
        //public CustomerRepository(StaySafeDBContext context) : base(context)
        //{   

        //}

        //public bool updateCustomer(Customer customer)
        //{
        //    var oldCust = _context.Customers.Find(customer.CustomerID);
        //    var city = _context.Cities.SingleOrDefault(x => x.Name == customer.City.Name);

        //    if (oldCust != null)
        //    {
        //        oldCust.FirstName = customer.FirstName;
        //        oldCust.LastName = customer.LastName;
        //        oldCust.EamilID = customer.EamilID;
        //        oldCust.PhoneNumber = customer.PhoneNumber;
        //        oldCust.Address = customer.Address;
        //        oldCust.CityID = city.CityID;
        //        oldCust.ZipCode = customer.ZipCode;
        //        oldCust.IsActive = customer.IsActive;
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public override void Delete(int id)
        //{
        //    var cust = _context.Customers.Find(id) ;
        //    _context.Customers.Remove(cust);
        //    _context.SaveChanges();
        //}

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;


        public CustomerRepository(StaySafeDBContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration) : base(context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;

        }

        public async Task<string> LoginUser(string userName, string password)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user != null && await userManager.CheckPasswordAsync(user, password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256)
                );
                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            return null;
        }

        public async Task<IdentityResult> RegisterUser(RegisterModel model)
        {

            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,
                PhoneNumber = model.PhoneNumber
            };


            var result = await userManager.CreateAsync(user, model.Password);

            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

            if (await roleManager.RoleExistsAsync(UserRoles.User))
            {
                await userManager.AddToRoleAsync(user, UserRoles.User);
            }

            if (result.Succeeded)
            {
                

                _context.Customers.Add(new Customer()
                {
                    PhoneNumber = model.PhoneNumber,
                     EamilID= model.Email,
                    Password = user.PasswordHash,
                    UserName = model.Username
                });
                _context.SaveChanges();
            }
            return result;
        }

        public Customer FindName(string name)
        {
            var registeredUser = _context.Customers.SingleOrDefault(x => x.UserName == name);
            return registeredUser;
        }

        public Customer FindContact(string contact)
        {
            var registeredUser = _context.Customers.SingleOrDefault(x => x.PhoneNumber == contact);
            return registeredUser;
        }
    }
}

