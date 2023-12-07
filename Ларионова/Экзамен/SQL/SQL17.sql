use Karshibaev
select count(Номер_по_журналу) as Количество_девoчек,Код_спец
from Группы inner join Студенты
on Группы.Группа=Студенты.Группа
where Пол='Ж'
group by Код_спец