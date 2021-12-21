using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHTTPMethods.Models
{
    public class Employee
    {
        [key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage="Name can only be 50 charactor long")]
        public string Name { get; set; }


    }
}
