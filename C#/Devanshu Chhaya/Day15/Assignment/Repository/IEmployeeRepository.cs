using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(long id);
        Employee AddEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
