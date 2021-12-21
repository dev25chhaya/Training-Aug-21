using System;
using System.Collections.Generic;

#nullable disable

namespace Healthcare.Models
{
    public partial class DrugSchedual
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
