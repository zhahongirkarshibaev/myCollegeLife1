Select DISTINCT LEFT (Фамилия, 1) AS буква 
FROM  dbo.Студенты
ORDER By буква 
SELECT Top 1 LEFT (Фамилия, 1) AS буква
FROM dbo.Студенты
ORDER BY буква DESC 