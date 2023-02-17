--CREATE PROC usp_GetEmployeesSalaryAbove35000 AS
--BEGIN
--		SELECT FirstName, LastName 
--		FROM Employees
--		WHERE Salary > 35000
--END

--EXEC usp_GetEmployeesSalaryAbove35000

--CREATE PROC usp_GetEmployeesSalaryAboveNumber(@Salary DECIMAL(18,4)) AS
--BEGIN
--		SELECT FirstName, LastName 
--		FROM Employees
--		WHERE Salary > @Salary
--END

--CREATE PROC usp_GetTownsStartingWith(@letter NVARCHAR(10)) AS
--BEGIN
--		SELECT Towns.[Name]
--		FROM Towns
--		WHERE Towns.[Name] LIKE @letter + '%'
--END

--EXEC dbo.usp_GetTownsStartingWith 'B'

--CREATE PROC usp_GetEmployeesFromTown (@Town NVARCHAR(40))
--AS
--BEGIN
--		SELECT FirstName, LastName
--		FROM Employees AS e
--		JOIN Addresses AS a ON e.AddressID = a.AddressID
--		JOIN Towns AS t ON t.TownID = a.TownID
--		WHERE t.[Name] = @Town	
--END

--CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
--RETURNS NVARCHAR(50) AS
--BEGIN
--		IF(@salary < 30000)
--		RETURN 'Low'
--		ELSE IF(@salary > 50000)
--		RETURN 'High'
--		RETURN 'Average'
--END

--CREATE PROC usp_EmployeesBySalaryLevel (@SalaryLevel VARCHAR(10))
--AS
--BEGIN
--		SELECT FirstName, LastName
--		FROM Employees
--		WHERE dbo.ufn_GetSalaryLevel(Salary) LIKE @SalaryLevel
--END

--CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(50), @word VARCHAR(50)) 
--RETURNS INT AS 
--BEGIN 

--	DECLARE @currentIndex int = 1;
--		WHILE(@currentIndex <= LEN(@word))
--		BEGIN
--		DECLARE @curLetter CHAR = SUBSTRING(@word, @currentIndex, 1);

--		IF(CHARINDEX(@curLetter, @setOfLetters)) = 0
--		RETURN 0;
--		SET @currentIndex += 1;
--	END
--RETURN 1;

--END

--SELECT dbo.ufn_IsWordComprised('osifaobr', 'Rob')



