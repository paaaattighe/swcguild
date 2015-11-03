--SQL 
--Relations and Joins

--Exercises in Relations and Joins

--Get a list of each employee and their territories.
SELECT FirstName, LastName, EmployeeTerritories.TerritoryID
FROM Employees
	INNER JOIN EmployeeTerritories
	ON Employees.EmployeeID = EmployeeTerritories.EmployeeID

--Get the Customer Name, Order Date, and each order detail’s Product name for USA customers only.
SELECT Customers.ContactName, CompanyName, OrderDate, ProductName, Country
FROM Customers
	INNER JOIN Orders
	ON Customers.CustomerID = Orders.CustomerID
	INNER JOIN [Order Details]
	ON Orders.OrderID = [Order Details].OrderID
	INNER JOIN Products
	ON [Order Details].ProductID = Products.ProductID
WHERE Country = 'USA'

--• Get all the order information where Chai was sold.
SELECT *
FROM Customers
	INNER JOIN Orders
	ON Customers.CustomerID = Orders.CustomerID
	INNER JOIN [Order Details]
	ON Orders.OrderID = [Order Details].OrderID
	INNER JOIN Products
	ON [Order Details].ProductID = Products.ProductID
WHERE ProductName = 'Chai'

--Code Alongs From Relations and Joins
SELECT ProductName, CategoryName
FROM Products
	INNER JOIN Categories
	ON Products.CategoryID = Categories.CategoryID

SELECT ProductName, CategoryName, CompanyName
FROM Products
	INNER JOIN Categories
	ON Products.CategoryID = Categories.CategoryID
	INNER JOIN Suppliers
	ON Products.SupplierID = Suppliers.SupplierID

SELECT OrderID, CustomerID, Orders.EmployeeID, 
	LastName, FirstName
FROM Orders
	INNER JOIN Employees
		ON Orders.EmployeeID = Employees.EmployeeID

SELECT OrderID, CustomerID, Orders.EmployeeID, LastName, FirstName
FROM Orders	
	LEFT JOIN Employees
		ON Orders.EmployeeID = Employees.EmployeeID
WHERE ORders.EmployeeID IS NULL OR LastName LIKE 'S%'


