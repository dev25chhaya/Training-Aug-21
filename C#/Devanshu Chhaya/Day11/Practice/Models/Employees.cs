﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFcorePrac.Models
{
    public partial class Employees
    {
        public decimal EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string JobId { get; set; }
        public decimal? Salary { get; set; }
        public decimal? CommissionPct { get; set; }
        public decimal? ManagerId { get; set; }
        public decimal? DepartmentId { get; set; }
    }
}
