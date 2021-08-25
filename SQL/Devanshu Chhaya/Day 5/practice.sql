
use [AdventureWorksLT2017]

select * from [SalesLT].[Product]
select * from[SalesLT].[ProductCategory]
select * from [SalesLT].[Customer]
select * from[SalesLT].[CustomerAddress]

select  c.FirstName,c.CustomerID,a.CustomerID,a.AddressID from [SalesLT].[Customer] as c left join [SalesLT].[CustomerAddress] as a on a.customerid=c.customerid


select c.FirstName,c.CompanyName,a.AddressType,a.CustomerID,c.CustomerID from [SalesLT].[Customer] as c join [SalesLT].[CustomerAddress] as a on c.customerid=a.customerid

select c.AddressID ,a.FirstName,a.CustomerID,c.CustomerID from [SalesLT].[CustomerAddress] as c right join [SalesLT].[Customer] as a on a.customerid=c.customerid

select a.AddressID ,c.FirstName from [SalesLT].[Customer] as c full join [SalesLT].[CustomerAddress] as a on a.customerid=c.customerid


----- Self Join


CREATE TABLE EMPLOYEE
(	ID INT PRIMARY KEY,
   FULLNAME VARCHAR(20),
   SALARY INT,
   MANAGERID INT

)
DROP TABLE EMPLOYEE
INSERT INTO EMPLOYEE VALUES 
(1,'DEV CHHAYA',25000,null),
(2,'RAJ',25000,1),
(3,'MEET',20000,1),
(4,'JAY',23000,2),
(5,'DEEP',24000,2);

SELECT * FROM EMPLOYEE

SELECT e.ID,e.FullName,e.managerID,m.fullname as'ManagerName' FROM EMPLOYEE e JOIN Employee m on e.managerid=m.ID

SELECT e.ID,e.FullName,e.managerID,m.fullname as'ManagerName' FROM EMPLOYEE e left JOIN Employee m on e.managerid=m.ID

SELECT e.ID,e.FullName,e.managerID,m.fullname as'ManagerName' FROM EMPLOYEE e right JOIN Employee m on e.managerid=m.ID
