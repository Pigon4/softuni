--SELECT CountryName,IsoCode
--FROM Countries
--WHERE CountryName LIKE '%a%a%a%'
--ORDER BY IsoCode

--SELECT p.PeakName, r.RiverName , LOWER(CONCAT('', p.PeakName, SUBSTRING(r.RiverName, 2 , LEN(r.RiverName) - 1))) AS Mix
--FROM Peaks AS p
--JOIN Rivers AS r ON SUBSTRING(p.PeakName, LEN(p.PeakName) , 1) = SUBSTRING(r.RiverName, 1 , 1)
--ORDER BY Mix
