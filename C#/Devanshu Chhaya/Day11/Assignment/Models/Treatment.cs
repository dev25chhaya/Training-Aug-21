﻿using System;
using System.Collections.Generic;

#nullable disable

namespace assignment.Models
{
    public partial class Treatment
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public int? PatientId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
