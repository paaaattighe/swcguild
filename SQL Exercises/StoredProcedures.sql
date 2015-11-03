--SQL 
--Stored Procedures

--Exercises in Stored Procedures

--Write a parameterized query to select the grant information from SWCCorp’s Grant table to show grants between a minimum and maximum value.
--DECLARE @Grants nchar(6)
--SET @Grants = 'Grants'

--DECLARE @MinGrant decimal
--DECLARE @MaxGrant decimal

--SET @MinGrant = 200
--SET @MaxGrant = 5000

--Code Alongs in Stored Procedures(northwind)
SELECT *
FROM Products
WHERE UnitPrice > 50.00

SELECT *
FROM Customers
WHERE CustomerID = 'BOTTM'

SELECT *
FROM Orders
WHERE CustomerID = 'BOTTM'


DECLARE @CustomerID nchar(5)
SET @CustomerID = 'BOTTM'

SELECT *
FROM Customers
WHERE CustomerID = @CustomerID

SELECT *
FROM Orders
WHERE CustomerID = @CustomerID


DECLARE @CustomerID nchar(5)
SET @CustomerID = 'BOTTM'

DECLARE @MinOrderDate datetime
DECLARE @MaxORderDate datetime

SET @MinOrderDate = '1/1/1997'
SET @MaxORderDate = '12/31/1997'

SELECT *
FROM Customers
WHERE CustomerID = @CustomerID

SELECT *
FROM Orders
WHERE CustomerID = @CustomerID
	AND Orderdate BETWEEN @MinOrderDate AND @MaxORderDate