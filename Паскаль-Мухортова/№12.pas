var D:array[1..6]of integer;
a,S,S1,S2:integer;
begin
  write('Введите числа: ');
  for a:=1 to 6 do
  read(D[a]);
  S:=0;
  S1:=0;
  S2:=0;
  for a:=1 to 3 do
  S:=S+D[a];
  for a:=3 to 5 do
  S1:=S1+D[a];
  for a:=4 to 6 do
  S2:=S2+D[a];
  writeln('Полученные суммы: ',S,' ',S1,' ',S2);
end.