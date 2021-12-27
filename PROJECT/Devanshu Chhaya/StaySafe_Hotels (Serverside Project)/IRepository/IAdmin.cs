using Microsoft.AspNetCore.Identity;
using StaySafeHotels.Authentication;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IAdmin
    {
        Task<IdentityResult> RegisterAdmin(RegisterModel model);
        public Admin FindName(string name);
        public Admin FindContact(string contact);
    }
}
