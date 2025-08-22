--mssql
SELECT [score], DENSE_RANK() OVER (ORDER BY [score] DESC) as rank FROM [Scores]

--mysql
SELECT score, DENSE_RANK() OVER (ORDER BY score DESC) `rank` FROM Scores