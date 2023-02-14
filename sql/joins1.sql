--SELECT TOP 5
--	e.EmployeeID
--	, e.JobTitle
--	, a.AddressID
--	, a.AddressText
--FROM Employees AS e
--JOIN Addresses AS a
--ON e.AddressID = a.AddressID
--ORDER BY AddressID ASC

--SELECT TOP 50
--	e.FirstName
--	, e.LastName
--	,t.[Name]
--	, a.AddressText
--FROM Employees AS e JOIN Addresses AS a ON e.AddressID = a.AddressID
--JOIN Towns AS t ON a.TownID = t.TownID
--ORDER BY FirstName, LastName

SELECT 
	e.EmployeeID
	, e.FirstName
	, e.LastName
	, d.[Name]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID AND d.[Name] = 'Sales'
ORDER BY EmployeeID
