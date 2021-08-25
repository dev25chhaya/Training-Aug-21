
----- subqueries

 USE AdventureWorks2016;
GO
SELECT [Name]
FROM Sales.Store
WHERE BusinessEntityID NOT IN
    (SELECT CustomerID
     FROM Sales.Customer
     WHERE TerritoryID = 5);
GO

-- Correlated Subqueries

USE AdventureWorks2016;
GO
SELECT DISTINCT c.LastName, c.FirstName, e.BusinessEntityID 
FROM Person.Person AS c JOIN HumanResources.Employee AS e
ON e.BusinessEntityID = c.BusinessEntityID 
WHERE 5000.00 IN
    (SELECT Bonus
    FROM Sales.SalesPerson sp
    WHERE e.BusinessEntityID = sp.BusinessEntityID) ;
GO


--- Subqueries With IN

USE AdventureWorks2016;
GO
SELECT [Name]
FROM Production.Product
WHERE ProductSubcategoryID IN
    (SELECT ProductSubcategoryID
     FROM Production.ProductSubcategory
     WHERE [Name] = 'Wheels');
GO

--- Subqueries with not in

USE AdventureWorks2016;
GO
SELECT [Name]
FROM Production.Product
WHERE ProductSubcategoryID NOT IN
    (SELECT ProductSubcategoryID
     FROM Production.ProductSubcategory
     WHERE [Name] = 'Mountain Bikes' 
        OR [Name] = 'Road Bikes'
        OR [Name] = 'Touring Bikes');
GO


--- Subqueries with comparison operators

USE AdventureWorks2016;
GO
SELECT CustomerID
FROM Sales.Customer
WHERE TerritoryID =
    (SELECT TerritoryID
     FROM Sales.SalesPerson
     WHERE BusinessEntityID = 276);
GO

