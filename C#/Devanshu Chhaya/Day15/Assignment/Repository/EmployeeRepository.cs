using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmpAssContext _context;

        public EmployeeRepository(EmpAssContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.EMployeeID);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                _context.Employees.Update(employee);
                _context.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(long id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
