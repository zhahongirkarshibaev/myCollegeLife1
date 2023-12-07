use Karshibaev
select distinct row_number() over(Order by Группа) as Номер_группы
from Группы