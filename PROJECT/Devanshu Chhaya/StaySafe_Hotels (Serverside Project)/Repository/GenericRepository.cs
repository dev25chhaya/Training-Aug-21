using Microsoft.EntityFrameworkCore;
using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class GenericRepository<T>: IGenericInterface<T> where T: class
    {
        protected readonly StaySafeDBContext _context;

        public GenericRepository(StaySafeDBContext context)
        {
            _context = context;
        }

        public virtual void Create(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual void Update(int id, T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        
    }
}
