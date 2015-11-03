--SQL 
--Basic Queries

--Exercises in Basic Queries

--From the Products table in NorthWind select all of the fields and the rows.
SELECT *
FROM Products

--. Find all the product information for the product with the name Queso Cabrales.
SELECT *
FROM Products
WHERE ProductName = 'Queso Cabrales'

--Using one query, display the name and number of units in stock for the products Laughing Lumberjack Lager, Outback Lager, and Ravioli Angelo.
SELECT ProductName, UnitsInStock
FROM Products 
WHERE ProductName IN ('Laughing Lumberjack Lager','Outback Lager', 'Ravioli Angelo')

--Select all the order information for the customer QUEDE.
SELECT *
FROM Customers
WHERE CustomerID = 'QUEDE'

--Select the orders whose freight is more than $100.00.SELECT *
FROM Orders
WHERE Orders.Freight > 100.00

--Select the orders shipping to the USA whose freight is between $10 and $20.
SELECT *
FROM Orders
WHERE Freight BETWEEN 10.00 AND 20.00
AND ShipCountry = 'USA'

--Code Alongs From Basic Queries
SELECT *
FROM Customers
WHERE Country = 'USA'

SELECT *
FROM Customers
WHERE Country != 'USA'

SELECT *
FROM Customers
WHERE Country = 'USA' AND Region = 'OR'

SELECT *
FROM Customers
WHERE Country IN ('USA', 'UK')

SELECT *
FROM Customers
WHERE Country NOT IN ('USA', 'UK')

SELECT *
FROM Products
WHERE UnitPrice > 20.00

SELECT *
FROM Products
WHERE UnitPrice <=20.00

SELECT *
FROM Products
WHERE UnitPrice BETWEEN 10.00 AND 13.00

SELECT Products.CategoryID
FROM Products

SELECT *
FROM Customers
WHERE CompanyName LIKE 'A%'

SELECT *
FROM Customers
WHERE CompanyName LIKE '%Z%'

SELECT *
FROM Customers
WHERE CompanyName LIKE '_A%'

SELECT *
FROM Customers
WHERE CompanyName LIKE '[AB]%'

