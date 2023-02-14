--SELECT * 
--FROM Employees
--WHERE JobTitle LIKE 'Sales Representative'

--SELECT FirstName, LastName, JobTitle
--FROM Employees
--WHERE Salary >= 20000 AND Salary <= 30000

--SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name]
--FROM Employees
--WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600

--SELECT FirstName, LastName, Salary
--FROM Employees
--WHERE Salary > 50000
--ORDER BY Salary DESC

--SELECT FirstName, LastName
--FROM Employees
--WHERE ManagerID IS NULL 

--SELECT TOP 5 FirstName, LastName
--FROM Employees
--ORDER BY Salary DESC

--SELECT FirstName, LastName
--FROM Employees
--WHERE DepartmentID != 4

--SELECT *
--FROM Employees
--ORDER BY Salary DESC
--,FirstName ASC
--,LastName DESC
--,MiddleName ASC

--SELECT DISTINCT JobTitle
--FROM Employees

--SELECT TOP (10) *
--FROM Projects
--ORDER BY StartDate, [Name] ASC
