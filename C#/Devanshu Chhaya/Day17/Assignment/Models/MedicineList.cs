using System;
using System.Collections.Generic;

#nullable disable

namespace Healthcare.Models
{
    public partial class MedicineList
    {
        public string PatientName { get; set; }
        public int? DrugId { get; set; }
        public string DrugName { get; set; }
        public string Timing { get; set; }
        public string Name { get; set; }
    }
}
