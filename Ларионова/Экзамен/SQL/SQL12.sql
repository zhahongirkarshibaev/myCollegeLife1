use Karshibaev
select Фамилия,Substring(Фамилия,1,1)+'.'+Substring([Отчество_(при наличии)],1,1) as Инициалы,Дата_рождения,
year(getdate())-year(Дата_рождения) as Количество_лет
from Студенты
where month(getdate())=month(Дата_рождения) and Day(getdate())=day(Дата_рождения)