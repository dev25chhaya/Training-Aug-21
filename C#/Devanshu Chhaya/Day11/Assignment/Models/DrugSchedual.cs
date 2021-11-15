using System;
using System.Collections.Generic;

#nullable disable

namespace assignment.Models
{
    public partial class DrugSchedual
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int? PatientId { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
