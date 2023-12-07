@echo off
setlocal enabledelayedexpansion
for /f "delims=" %%i in ('dir %1/ad/t:c') do set t=%%i && (set year=!t:~6,4!) && echo !year!
pause
set max=1
set min=1
set symbol=%1
if "%symbol%"=="-" echo Максимальное значение:%max%  
echo Минимальное значение:%min%
echo %min
echo %max
pause