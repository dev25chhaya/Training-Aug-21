using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;

namespace Assignment.Repository
{
    public interface IAssignmentRepository
    {
        Assignments AddAssignment(int EmployeeId, Assignments assignment);
        List<Assignments> GetAssignments(int EmployeeId);
        Assignments GetAssignment(int EmployeeId, int AssignmentId);
        Assignments UpdateAssignment(int EmployeeId, int AssignmrntId, Assignments assignment);
    }
}
