using Assignment.Models;
using Assignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controller
{
    
    [ApiController]
    public class assignmentController : ControllerBase
    {
        
        private readonly IAssignmentRepository _assignment;

        public assignmentController(IAssignmentRepository assignment)
        {
            _assignment = assignment;
        }

        [HttpGet]
        [Route("api/emps/{id}/assignment")]
        public IActionResult GetAssignments(int id)
        {
            return Ok(_assignment.GetAssignments(id));
        }

        [HttpGet]
        [Route("api/emps/{empid}/assignment/{AssignmentID}")]
        public IActionResult GetAssignment(int empId, int assignmentId)
        {
            var employee = _assignment.GetAssignment(empId, assignmentId);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Assignment not found");
        }

        [HttpPost]
        [Route("api/emps/{empid}/assignment")]
        public IActionResult AddAssignment(int id, Assignments assignments)
        {
            return Ok(_assignment.AddAssignment(id, assignments));
        }

        [HttpPatch]
        [Route("api/emps/{empid}/assignment/{AssignmentID}")]
        public IActionResult EditAssignment(int empid, int assiId, Assignments assignments)
        {
            var ExistingAssignment = _assignment.GetAssignment(empid, assiId);
            if (ExistingAssignment != null)
            {
                assignments.AssignmentName = ExistingAssignment.AssignmentName;
                _assignment.UpdateAssignment(empid, assiId, assignments);
            }
            return Ok(assignments);
        }
    }
}
