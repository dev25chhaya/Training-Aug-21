---2.1--- Get all employee details from the Employee table

SELECT * FROM dbo.Employees;

----2.2 Get FirstName, LastName from Employees table

SELECT FirstName, LastName FROM dbo.Employees;

----2.3 Get FirstName from Employees table using alias name "Employee Name"

SELECT FirstName 'Employee name' FROM dbo.Employees;

---2.4 Get employee details from Employees table whose Employee Name is “Steven”

SELECT * FROM dbo.Employees WHERE FirstName='Steven';

----2.5 Get employee details from Employees table whose Employee Name are “Neena” and “Lex”

SELECT * FROM dbo.Employees WHERE FirstName IN('Neena','Lex');

----2.6 Get employee details from Employees table whose Employee name are not “Neena” and “Neena”

SELECT * FROM dbo.Employees WHERE FirstName NOT IN('Neena','Lex');

---2.7-- Get employee details from Employees table whose Salary between 5000 and 8000

SELECT * FROM dbo.Employees WHERE Salary BETWEEN 5000 AND 8000;

---2.8 Write a query to get the names (FirstName, LastName), Salary, PF of all the Employees (PF is calculated as 12% of salary).

SELECT FirstName+' '+LastName AS Name,Salary,PF=.12*Salary  From dbo.Employees;

---2.9 Get employee details from Employees table whose FirstName starts with ‘N’

SELECT FirstName FROM dbo.Employees WHERE FirstName like 'N%'

----2.10 Write a query to get unique department ID from Employees table

SELECT Distinct DepartmentID FROM dbo.Employees;

----2.11 Write a query to get all employee details from the employee table order by FirstName, descending.

SELECT * FROM dbo.Employees ORDER BY FirstName DESC;

---2.12 Write a query to get the EmployeeID, names (FirstName, LastName), salary in ascending order of salary.

SELECT EmployeeID, FirstName+' '+LastName AS Name, Salary FROM dbo.Employees ORDER BY Salary ASC;

----2.13 Select TOP 2 salary from employee table

SELECT TOP 2 Salary FROM dbo.Employees;

