program Treugolnik;
var
x1, x2,x3, y1,y2,y3:integer;
S:real;
begin
  writeln('Введите точки x1, y1');
  readln(x1, y1);
  writeln('Введите точки x2, y2');
  readln(x2, y2);
  writeln('Введите точки x3, y3');//Вводим координаты треуголника A,B,C
  readln(x3, y3);
  S:=abs((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1))/2;
  writeln(S);
end.
