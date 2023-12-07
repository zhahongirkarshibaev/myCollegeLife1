use Karshibaev
alter table Группы drop column Группа
alter table Группы add Группа varchar(50) NULL
update Группы set Группа='1'
where Группа='ЗИО-114'
update Группы set Группа='2'
where Группа='ПКС-308'
update Группы set Группа='3'
where Группа='ИСП-208'
update Группы set Группа='4'
where Группа='ИСП-308'
update Группы set Группа='5'
where Группа='Р-304'
update Группы set Группа='6'
where Группа='СИС-208'
select distinct Группы.Группа,Фамилия
from Группы inner join Студенты
on Студенты.Группа=Группы.Группа
