using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysManufacturingCompany.Models;

namespace ToysCompany.Interfaces
{
    public interface IProductRepository
    {
        List<Toys> GetToys();
        Toys GetToy(Guid id);

        Toys AddToy(Toys toy);
        void DeleteToy(Toys toys);
        Toys EditToy(Toys toys);
    }
}
