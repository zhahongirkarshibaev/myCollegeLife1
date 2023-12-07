USE Karshibaev
select left(right(Группа,3),1) as Курс,count(Номер_по_журналу) as Количество_студентов
from Студенты
group by Группа
having count(Номер_по_журналу)>2