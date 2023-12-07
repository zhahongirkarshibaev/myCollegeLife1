USE Karshibaev
if (select top 1 Фамилия from Студенты where Фамилия like '%[ь]')=(select top 1 Фамилия from Студенты where Группа='ИСП-208')
begin
update Студенты set Фамилия='Каршибаев'
where Пол='М' and Фамилия=(select top 1 Фамилия from Студенты where Группа='ИСП-208')
end;
else
begin
update Студенты set Фамилия='Каршибаев'
where Пол='М' and Фамилия=(select top 1 Фамилия from Студенты where Группа='ИСП-208')
end
select Фамилия from Студенты