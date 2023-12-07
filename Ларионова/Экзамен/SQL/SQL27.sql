USE Karshibaev
select Группа, substring(Группа,1, charindex('-',Группа,1)) 
+ cast(cast(substring (Группа, charindex('-',Группа,1) +1,3) as int) 
+100 as char(3)) as New_Group
from Студенты