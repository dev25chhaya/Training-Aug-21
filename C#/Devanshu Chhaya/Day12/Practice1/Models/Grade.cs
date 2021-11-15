using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public IList<Student> Students { get; set; }
    }
}
