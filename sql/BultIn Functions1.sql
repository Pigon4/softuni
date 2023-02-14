--SELECT FirstName, LastName
--FROM Employees
--WHERE FirstName LIKE 'Sa%'

--SELECT FirstName, LastName
--FROM Employees
--WHERE LastName LIKE '%ei%'

--SELECT FirstName
--FROM Employees
--WHERE DepartmentID IN (3, 10) AND YEAR(HireDate) BETWEEN 1995 AND 2005

--SELECT FirstName, LastName
--FROM Employees
--WHERE JobTitle NOT LIKE '%engineer%'

--SELECT Towns.[Name]
--FROM Towns
--WHERE LEN([Name]) IN (5, 6)
--ORDER BY [Name]

--SELECT TownID, [Name]
--FROM Towns
--WHERE [NAME] LIKE '[MKBE]%'
--ORDER BY [Name]

--SELECT TownID, [Name]
--FROM Towns
--WHERE [NAME] NOT LIKE '[RBD]%'
--ORDER BY [Name]

--CREATE VIEW V_EmployeesHiredAfter2000 AS
--SELECT FirstName, LastName
--FROM Employees
--WHERE YEAR(HireDate) > 2000

--SELECT FirstName, LastName
--FROM Employees
--WHERE LEN(LastName) = 5

--SELECT EmployeeID, FirstName, LastName, Salary,
--DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS Drank
--FROM Employees
--WHERE Salary BETWEEN 10000 AND 50000
--ORDER BY Salary DESC

--SELECT * FROM(SELECT EmployeeID, FirstName, LastName, Salary,
--DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS Drank
--FROM Employees
--WHERE Salary BETWEEN 10000 AND 50000) AS s 
--WHERE s.Drank = 2
--ORDER BY Salary DESC
