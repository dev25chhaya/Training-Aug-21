using Microsoft.AspNetCore.Identity;
using StaySafeHotels.Authentication;
using StaySafeHotels.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using StaySafeHotels.Models;

namespace StaySafeHotels.Repository
{
    public class AdminRepository: GenericRepository<ApplicationUser>,IAdmin
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
       

        public AdminRepository(StaySafeDBContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration) : base(context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            
        }

        public async Task<IdentityResult> RegisterAdmin(RegisterModel model)
        {
            ApplicationUser admin = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,
                PhoneNumber = model.PhoneNumber
            };
            var result = await userManager.CreateAsync(admin, model.Password);

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

            if (await roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await userManager.AddToRoleAsync(admin, UserRoles.Admin);
            }

            if (result.Succeeded)
            {
                _context.Admins.Add(new Admin()
                {
                    ContactNo = model.PhoneNumber,
                    Email = model.Email,
                    Password = model.Password,
                    UserName = model.Username
                });

                _context.SaveChanges();
            }

            return result;
        }

        // Map admin details to Admins table in BookMyShowDB from Users table in BookMyShowAuthenticationAPIDB
        public Admin FindName(string name)
        {
            var registeredAdmin = _context.Admins.SingleOrDefault(x => x.UserName == name);
            return registeredAdmin;
        }

        public Admin FindContact(string contact)
        {
            var registeredAdmin = _context.Admins.SingleOrDefault(x => x.ContactNo == contact);
            return registeredAdmin;
        }

    }
}
