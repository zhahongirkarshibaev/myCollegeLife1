use Karshibaev
select Группа,count(Группа) as Количество_студентов 
from Студенты  
group by Группа
having count(Группа)>2