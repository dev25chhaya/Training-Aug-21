using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Interfaces;
using ToysCompany.Models;
using ToysManufacturingCompany.Models;

namespace ToysCompany.Repository
{
    public class ProductRepository : IProductRepository
    {
        public readonly ToysCompanyContext _context;
        public ProductRepository(ToysCompanyContext context)
        {
            _context = context;
        }
        public Toys AddToy(Toys toy)
        {
            toy.ToysID = Guid.NewGuid();
            _context.Toys.Add(toy);
            _context.SaveChanges();
            return toy;
        }

        public void DeleteToy(Toys toys)
        {
            _context.Toys.Remove(toys);
            _context.SaveChanges();
        }

        public Toys EditToy(Toys toys)
        {
            var ExistingToy = _context.Toys.Find(toys.ToysID);
            if (ExistingToy != null)
            {
                ExistingToy.Name = toys.Name;
                _context.Toys.Update(toys);
                _context.SaveChanges();
            }
            return toys;
        }

        public Toys GetToy(Guid id)
        {
            var toy = _context.Toys.Find(id);
            return toy;
        }

        public List<Toys> GetToys()
        {
            return _context.Toys.ToList();
        }
    }
}
