--STRING FUNCTION:

--LEN() , SUBSTING():
SELECT FirstName
FROM Employees
WHERE LEN(FirstName)>=8

SELECT FirstName, LEN(FirstName) AS LENTHOFF_NAME
FROM Employees
WHERE SUBSTRING(FirstName,1,1) IN('A','J','M')
ORDER BY FirstName DESC

--CHARINDEX():
SELECT FirstName
FROM Employees 
WHERE CHARINDEX('C',LastName)>2

--RIGHT():
SELECT RIGHT(PhoneNumber,10)
FROM Employees

--REPLICATE():
SELECT REPLICATE('$',10-LEN(SALARY))+ CAST(SALARY AS varchar)
FROM Employees

--REPLACE():
SELECT REPLACE(PhoneNumber,'124','999')
FROM Employees

SELECT REPLACE('AAAAAAAABB','BB','CC')

--LTRIM():
SELECT LTRIM(FirstName)
FROM Employees


select SUBSTRING('rutvikprajapati08@gmail.com',
CHARINDEX('@','rutvikprajapati08@gmail.com')+1,
LEN('rutvikprajapati08@gmail.com')-CHARINDEX('@','rutvikprajapati08@gmail.com'))

-- ASCII
SELECT ASCII('C')

-- CHAR
SELECT CHAR(50)

-- CONCAT
SELECT CONCAT(ASCII('C'),+' '+CHAR(50))
SELECT CONCAT('RUTVIK',' ','PRAJAPATI')

-- FORMAT
DECLARE @TODAYDATE DATE = GETDATE()
SELECT FORMAT(@TODAYDATE,'d','EN-US'),
		FORMAT(@TODAYDATE,'D','EN-US'),
		FORMAT(@TODAYDATE,'')
-- LEFT
SELECT LEFT('RUTVIK',2)

-- LOWER
SELECT LOWER('TRAINEE')

-- PATINDEX
SELECT PATINDEX('%ab%','BCabDDBD')
SELECT PATINDEX('%aa%','BCabDDBD')
SELECT PATINDEX('%ab%','this is ab string')

-- RTRIM
SELECT RTRIM('THIS IS A RTRIM EX  ')

-- SOUNDEX
SELECT SOUNDEX('RIGHT'),SOUNDEX('WRITE')
SELECT SOUNDEX('BUS'),SOUNDEX('BAAS')

-- SPACE
SELECT RTRIM(LastName) + ',' + SPACE(5) +  LTRIM(FirstName)  
FROM Employees  
ORDER BY LastName, FirstName; 

-- STR
SELECT STR(123.45, 8, 7);

-- STUFF SYNTAX  : STUFF(EXPRESSION,START,LEN OF DELETE CHAR,REPLACE STRING)
SELECT STUFF('ABCDEFGH',2,6,'RUTVIK')

-- TRIM
SELECT TRIM( '   TRAINEE  LEARN SQL  # ') AS Result;

-- REVERSE
SELECT REVERSE('TRAINEE')

--Date Functions:
--Dateadd
SELECT DATEADD(month, 1, GETDATE());
SELECT DATEADD(DAY, 1, GETDATE());
SELECT DATEADD(YEAR, 1, GETDATE());
SELECT DATEADD(YY, 1, GETDATE());

--datename 
SELECT DATENAME(DD,GETDATE())
SELECT DATENAME(MM,GETDATE())
SELECT DATENAME(YY,GETDATE())
SELECT DATENAME(YYYY,GETDATE())

--getdate 
SELECT GETDATE()

--day
SELECT DAY(GETDATE())


