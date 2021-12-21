using System;
using System.Collections.Generic;

#nullable disable

namespace Healthcare.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            DrugScheduals = new HashSet<DrugSchedual>();
            Treatments = new HashSet<Treatment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<DrugSchedual> DrugScheduals { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
