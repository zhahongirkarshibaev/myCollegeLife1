Program delenie;
var
  A, B, C, D:integer;
  S,S1, n:real;
begin 
  writeln('Введите A,B');
  read(A, B);
  writeln('Введите C, D');
  read(C, D);
  S:= A*D;
  S1:=B*C;
  n:=S/S1;
  writeln(n);
  writeln(S,'/',S1);
end.