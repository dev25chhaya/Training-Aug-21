using System;
using System.Collections.Generic;

#nullable disable

namespace assignment.Models
{
    public partial class Drug
    {
        public Drug()
        {
            DrugScheduals = new HashSet<DrugSchedual>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Timing { get; set; }

        public virtual ICollection<DrugSchedual> DrugScheduals { get; set; }
    }
}
