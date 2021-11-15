using System;
using System.Collections.Generic;

#nullable disable

namespace assignment.Models
{
    public partial class Patient
    {
        public Patient()
        {
            DrugScheduals = new HashSet<DrugSchedual>();
            Treatments = new HashSet<Treatment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int? AssistanceId { get; set; }

        public virtual HealthcareAss Assistance { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<DrugSchedual> DrugScheduals { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
