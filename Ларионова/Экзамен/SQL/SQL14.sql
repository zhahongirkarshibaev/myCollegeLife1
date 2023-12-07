use Karshibaev
select year(Дата_рождения) as Год,count(Номер_по_журналу) as Количество
from Студенты
group by year(Дата_рождения)
having count(Номер_по_журналу)>4