use Karshibaev
select ������,substring(������,1, charindex('-',������,1)) + 
cast(cast(substring (������, charindex('-',������,1) +1,3) as int) +1 as char(3)) as New_Group
from ��������
Where �������='���������'