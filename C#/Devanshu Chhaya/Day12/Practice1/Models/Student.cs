using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade Grade;
    }
}
