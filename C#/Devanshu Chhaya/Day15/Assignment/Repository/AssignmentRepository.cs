using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly EmpAssContext _context;
        
        public AssignmentRepository(EmpAssContext context)
        {
            _context = context;
        }
        public Assignments AddAssignment(int EmployeeId, Assignments assignment)
        {
            assignment.EmployeeRefId = EmployeeId;
            var data = _context.Employees.SingleOrDefault(s => s.EMployeeID == EmployeeId);
            if (data == null)
            {
                return assignment;
            }
            _context.Assignments.Add(assignment);
            _context.SaveChanges();
            return assignment;
        }

        public Assignments GetAssignment(int EmployeeId, int AssignmentId)
        {
            var assignment = _context.Assignments.SingleOrDefault(s => s.EmployeeRefId == EmployeeId && s.AssignmentID == AssignmentId);
            return assignment;
        }

        public List<Assignments> GetAssignments(int EmployeeId)
        {
            var assignment = _context.Assignments.Where(s=>s.EmployeeRefId==EmployeeId).ToList();
            return assignment;
        }

        public Assignments UpdateAssignment(int EmployeeId, int AssignmentId, Assignments assignment)
        {
            var Existingassi = _context.Assignments.SingleOrDefault(s => s.EmployeeRefId == EmployeeId && s.AssignmentID == AssignmentId);
            if (Existingassi != null)
            {
                Existingassi.AssignmentName = assignment.AssignmentName;
            }
            return assignment;
        }
    }
}
