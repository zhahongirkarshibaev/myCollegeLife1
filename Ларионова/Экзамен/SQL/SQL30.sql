USE Karshibaev
drop table Успеваемость_студентов
create table Успеваемость_студентов (
Number int NOT NULL primary key clustered,
Groups nvarchar(50) NOT NULL,
Discipline_Code nchar(8)  NULL,
Semester_Number int  NULL,
Evaluation int  NULL,
constraint fk_Groups foreign key (Groups)
)
go