use Karshibaev
select distinct
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='1')as Январь,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='2')as Февраль,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='3')as Март,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='4')as Апрель,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='5')as Май,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='6')as Июнь,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='7')as Июль,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='8')as Август,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='9')as Сентябрь,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='10')as Октябрь,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='11')as Ноябрь,
(select count(month(Дата_рождения)) from Студенты where month(Дата_рождения)='12')as Декабрь 
from Студенты
