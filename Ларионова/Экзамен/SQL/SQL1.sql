USE Karshibaev
GO

Select Фамилия, Дата_рождения From Студенты
WHERE DAY(Дата_рождения) BETWEEN 1 AND 15