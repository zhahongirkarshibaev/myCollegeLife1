USE Karshibaev
select Фамилия
from Студенты 
where Пол='М'
group by Фамилия 
having count(Фамилия)>1
go
select Фамилия 
from Студенты 
where Пол='Ж'
group by Фамилия 
having count(Фамилия)>1
go