USE Karshibaev
select count(Номер_по_журналу)as Фамилии,substring(Группа,1,1) as Первая_буква
from Студенты
group by Группа