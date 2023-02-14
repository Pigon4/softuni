--SELECT TOP (50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS [Start]
--FROM Games
--WHERE YEAR([Start]) BETWEEN 2011 AND 2012
--ORDER BY [Start], [Name]

--SELECT Username, SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(EMAIL)) AS [Email Provider]
--FROM Users
--ORDER BY [Email Provider] , Username
