--SELECT * FROM(
--SELECT wd.DepositGroup AS 'DepositGroup', SUM(wd.DepositAmount) AS TotalSum
--FROM WizzardDeposits AS wd
--WHERE wd.MagicWandCreator = 'Ollivander family' 
--GROUP BY wd.DepositGroup) as q
--WHERE q.TotalSum < 150000
--ORDER BY TotalSum DESC

--SELECT wd.DepositGroup, wd.MagicWandCreator, MIN(wd.DepositCharge) AS 'MinDepositCharge'
--FROM WizzardDeposits AS wd
--GROUP BY wd.DepositGroup, wd.MagicWandCreator

--SELECT *, COUNT(AgeGroup) FROM (
--SELECT 
--		CASE
--		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
--		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
--		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
--		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
--		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
--		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
--		ELSE '[61+]'
--		END
--		AS AgeGroup
--FROM WizzardDeposits AS wd) AS q
--GROUP BY q.AgeGroup

--SELECT DISTINCT SUBSTRING(FirstName, 1, 1)
--FROM WizzardDeposits AS wd
--WHERE DepositGroup = 'Troll Chest'
--GROUP BY wd.FirstName

--SELECT DepositGroup, wd.IsDepositExpired ,AVG(DepositInterest) AS AverageInterest
--FROM WizzardDeposits AS wd
--WHERE wd.DepositStartDate > '1985-01-01'
--GROUP BY DepositGroup, wd.IsDepositExpired
--ORDER BY DepositGroup DESC, IsDepositExpired 


