USE Karshibaev
select left(right(������,3),1) as ����,count(�����_��_�������) as ����������_���������
from ��������
group by ������
having count(�����_��_�������)>2