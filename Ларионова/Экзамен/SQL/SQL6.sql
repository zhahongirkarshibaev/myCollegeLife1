USE Karshibaev
if (select top 1 ������� from �������� where ������� like '%[�]')=(select top 1 ������� from �������� where ������='���-208')
begin
update �������� set �������='���������'
where ���='�' and �������=(select top 1 ������� from �������� where ������='���-208')
end;
else
begin
update �������� set �������='���������'
where ���='�' and �������=(select top 1 ������� from �������� where ������='���-208')
end
select ������� from ��������