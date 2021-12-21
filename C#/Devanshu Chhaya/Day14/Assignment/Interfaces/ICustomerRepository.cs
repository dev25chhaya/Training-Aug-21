using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Models;

namespace ToysCompany.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(Guid id);

        Customer AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer EditCustomer(Customer customer);

    }
}
