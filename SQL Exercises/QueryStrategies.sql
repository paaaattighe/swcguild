--SQL 
--Query Strategies

--Exercises in Query Strategies

--Write a query to show every combination of employee and location.SELECT *
From Location
	INNER JOIN Employee
	ON Location.LocationID = Employee.LocationID

--Find a list of all the Employees who have never found a Grant. 
SELECT *
FROM Employee
	LEFT OUTER JOIN [Grant]
	ON Employee.EmpID = [Grant].EmpID
	WHERE [Grant].EmpID IS NULL

--Code Alongs in Query Strategies
SELECT *
FROM Location

SELECT *
FROM Location
	INNER JOIN Employee
	ON Location.LocationID = Employee.LocationID

SELECT *
FROM Location
	INNER JOIN Employee
	ON Location.LocationID = Employee.LocationID
WHERE [State] = 'WA'

SELECT FirstName, LastName, City, [State]
From Location
	INNER JOIN Employee
	ON Location.LocationID = Employee.LocationID
WHERE [State] = 'WA'

SELECT FirstName, LastName, City, [State]
FROM Location AS loc
	INNER JOIN Employee AS emp
	ON loc.LocationID = emp.LocationID
WHERE [State] = 'WA'

SELECT FirstName, LastName, City, [State]
FROM Location loc
	INNER JOIN Employee emp
	ON loc.LocationID = emp.LocationID
WHERE [State] = 'WA'

SELECT emp.FirstName, emp.LastName, loc.City, loc.[State]
FROM Location loc
	INNER JOIN Employee emp
	ON loc.LocationID = emp.LocationID
WHERE loc.[State] = 'WA'

SELECT *
FROM Employee
WHERE EmpID IN (1,2)

SELECT *
FROM MgmtTraining

SELECT *
FROM Employee
CROSS JOIN MgmtTraining
WHERE EmpID IN (1, 2)

SELECT *
FROM Location AS l
	LEFT OUTER JOIN Employee AS e
	ON l.LocationID = e.LocationID
WHERE e.LocationID IS NULL


