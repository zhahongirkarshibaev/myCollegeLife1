use Karshibaev
select distinct
(select count(month(����_��������)) from �������� where month(����_��������)='1')as ������,
(select count(month(����_��������)) from �������� where month(����_��������)='2')as �������,
(select count(month(����_��������)) from �������� where month(����_��������)='3')as ����,
(select count(month(����_��������)) from �������� where month(����_��������)='4')as ������,
(select count(month(����_��������)) from �������� where month(����_��������)='5')as ���,
(select count(month(����_��������)) from �������� where month(����_��������)='6')as ����,
(select count(month(����_��������)) from �������� where month(����_��������)='7')as ����,
(select count(month(����_��������)) from �������� where month(����_��������)='8')as ������,
(select count(month(����_��������)) from �������� where month(����_��������)='9')as ��������,
(select count(month(����_��������)) from �������� where month(����_��������)='10')as �������,
(select count(month(����_��������)) from �������� where month(����_��������)='11')as ������,
(select count(month(����_��������)) from �������� where month(����_��������)='12')as ������� 
from ��������
