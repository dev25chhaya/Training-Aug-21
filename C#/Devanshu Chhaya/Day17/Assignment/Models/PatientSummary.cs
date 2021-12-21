using System;
using System.Collections.Generic;

#nullable disable

namespace Healthcare.Models
{
    public partial class PatientSummary
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int TreamentId { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DepartmentName { get; set; }
        public string AssistantName { get; set; }
        public int? DrugsId { get; set; }
        public int? DoctorIdofDrug { get; set; }
        public string DrugName { get; set; }
        public string DrugTiming { get; set; }
    }
}
