USE Karshibaev
select count(Номер_по_журналу) as Количество_студентов, Группа
from Студенты
Group by Группа