use Karshibaev
select count(Номер_по_журналу) as Количество_девушек,Группа
from Студенты
where Пол='Ж'
group by Группа