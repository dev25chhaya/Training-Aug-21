using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class StateRepository: GenericRepository<State>,IState
    {
        public StateRepository(StaySafeDBContext context) : base(context)
        {

        }

        public override void Delete(int id)
        {
            var state = _context.States
                                .Where(x => x.StateID == id)
                                .SingleOrDefault();
            _context.States.Remove(state);
            _context.SaveChanges();
        }

        public bool updateState(State states)
        {
            var old = _context.States.Find(states.StateID);
            
            if (old != null)
            {
                old.StateName = states.StateName;
                old.IsActive = states.IsActive;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
