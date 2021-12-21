using System;
using System.Collections.Generic;

#nullable disable

namespace Healthcare.Models
{
    public partial class DoctorSummary
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int TreatmentId { get; set; }
        public string PatientName { get; set; }
        public string DepartmentName { get; set; }
    }
}
