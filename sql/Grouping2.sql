--SELECT DepartmentID, SUM(Salary)
--FROM Employees AS e
--GROUP BY DepartmentID

--SELECT DepartmentID, MIN(Salary)
--FROM Employees AS e
--WHERE DepartmentID IN (2, 5, 7) AND HireDate > '01-01-2000'
--GROUP BY DepartmentID

--SELECT * 
--FROM(
--SELECT DepartmentID, MAX(Salary) AS MaxSalary
--FROM Employees AS e
--GROUP BY DepartmentID) as q
--WHERE q.MaxSalary NOT BETWEEN 30000 AND 70000

--SELECT COUNT(q.EmployeeID) AS 'Count'
--FROM(
--SELECT * 
--FROM Employees AS e
--WHERE ManagerID IS NULL) AS q
