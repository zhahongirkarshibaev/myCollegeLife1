@echo off
setlocal enabledelayedexpansion
:input_variable
set /A number+=1
set /p "var_%number%=Введите число: "
if not "!var_%number%!"=="-" goto input_variable
set var_
pause