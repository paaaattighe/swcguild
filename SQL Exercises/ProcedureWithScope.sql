CREATE PROCEDURE EmployeeGetAll
AS
BEGIN
	SELECT * FROM Employees
END

CREATE PROCEDURE RegionInsert(
	@RegionDescription nchar(50),
	@RegionId int output
	) AS
BEGIN
	INSERT INTO Region (RegionDescription)
	VALUES (@RegionDescription);

	SET @RegionId = SCOPE_IDENTITY();
END