using System;
using System.Collections.Generic;

#nullable disable

namespace Healthcare.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctors = new HashSet<Doctor>();
            HealthcareAsses = new HashSet<HealthcareAss>();
            Patients = new HashSet<Patient>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<HealthcareAss> HealthcareAsses { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
