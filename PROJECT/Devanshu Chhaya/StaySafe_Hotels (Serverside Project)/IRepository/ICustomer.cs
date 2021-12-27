using Microsoft.AspNetCore.Identity;
using StaySafeHotels.Authentication;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface ICustomer: IGenericInterface<ApplicationUser>
    {
        //bool updateCustomer(Customer customer);
        Task<IdentityResult> RegisterUser(RegisterModel model);
        Task<string> LoginUser(string userName, string password);
        public Customer FindName(string name);

        public Customer FindContact(string contact);

    }
}
