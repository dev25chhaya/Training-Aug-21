using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class ManagerRepository: GenericRepository<Manager>,IManager
    {
        public ManagerRepository(StaySafeDBContext context) : base(context)
        {

        }

        public bool updateMan(Manager managnager)
        {
            var old = _context.Managers.Find(managnager.ManagerID);
            var owner = _context.Owners.SingleOrDefault(x => x.OwnerFullName == managnager.Owner.OwnerFullName);
            var city = _context.Cities.SingleOrDefault(x => x.Name == managnager.City.Name);

            if (old != null)
            {
                old.OwnerID = owner.OwnerID;
                old.FullName = managnager.FullName;
                old.EmailID = managnager.EmailID;
                old.PhoneNumber = managnager.PhoneNumber;
                old.Address = managnager.Address;
                old.CityID = city.CityID;
                old.ZipCode = managnager.ZipCode;
                old.IsActive = managnager.IsActive;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Delete(int id)
        {
            var manager = _context.Managers.Find(id);
            _context.Managers.Remove(manager);
            _context.SaveChanges();
        }
    }
}
