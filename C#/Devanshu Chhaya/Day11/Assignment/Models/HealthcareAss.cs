using System;
using System.Collections.Generic;

#nullable disable

namespace assignment.Models
{
    public partial class HealthcareAss
    {
        public HealthcareAss()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
