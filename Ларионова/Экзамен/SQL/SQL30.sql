USE Karshibaev
drop table ������������_���������
create table ������������_��������� (
Number int NOT NULL primary key clustered,
Groups nvarchar(50) NOT NULL,
Discipline_Code nchar(8)  NULL,
Semester_Number int  NULL,
Evaluation int  NULL,
constraint fk_Groups foreign key (Groups)
)
go