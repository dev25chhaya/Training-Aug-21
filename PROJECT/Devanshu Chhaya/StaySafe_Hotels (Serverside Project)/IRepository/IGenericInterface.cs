using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IGenericInterface<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Delete(int id);
        void Update(int id,T entity);
        
    }
}
