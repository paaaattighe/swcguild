--RANK DENSE_RANK ROW_NUMBER CTEs CODE ALONG
WITH BaseTable AS (
SELECT e.LastName, e.FirstName
	, SUM(g.Amount) AS TotalGrants
FROM [Grant] g
	LEFT JOIN Employee e
	ON g.EmpID = e.EmpID
GROUP BY e.LastName, e.FirstName
)

SELECT *
	, RANK() OVER(ORDER BY TotalGrants DESC) AS [RANK]
	, DENSE_RANK() OVER(ORDER BY TotalGrants DESC) AS [DENSE RANK]
	, ROW_NUMBER() OVER(ORDER BY TotalGrants DESC) AS [ROW NUMBER] 
	, NTILE(4) OVER(ORDER BY TotalGrants DESC) AS [Percentile] 
FROM BaseTable
