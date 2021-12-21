using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Interfaces;
using ToysCompany.Models;

namespace ToysCompany.Repository
{
    public class CustomerRepoository : ICustomerRepository
    {
        private readonly ToysCompanyContext _context;

        public CustomerRepoository(ToysCompanyContext context)
        {
            _context = context;
        }
        
        public Customer AddCustomer(Customer customer)
        {
            customer.CustomerID = Guid.NewGuid();
            _context.customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.customers.Remove(customer);
            _context.SaveChanges();
        }

        public Customer EditCustomer(Customer customer)
        {
            var ExistingCustomer = _context.customers.Find(customer.CustomerID);
            if (ExistingCustomer!=null)
            {
                ExistingCustomer.Name = customer.Name;
                _context.customers.Update(ExistingCustomer);
                _context.SaveChanges();
            }
            return customer;
        }

        public Customer GetCustomer(Guid id)
        {
            var customer = _context.customers.Find(id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _context.customers.ToList();
        }
    }
}
