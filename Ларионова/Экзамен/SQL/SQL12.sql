use Karshibaev
select �������,Substring(�������,1,1)+'.'+Substring([��������_(��� �������)],1,1) as ��������,����_��������,
year(getdate())-year(����_��������) as ����������_���
from ��������
where month(getdate())=month(����_��������) and Day(getdate())=day(����_��������)