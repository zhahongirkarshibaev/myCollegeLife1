use Karshibaev
select year(����_��������) as ���,count(�����_��_�������) as ����������
from ��������
group by year(����_��������)
having count(�����_��_�������)>4