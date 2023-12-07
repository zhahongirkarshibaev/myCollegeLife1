USE Karshibaev
select count(Номер_по_журналу) as Количество_студентов ,year(Дата_рождения) as Год
from Студенты
Group by year(Дата_рождения)