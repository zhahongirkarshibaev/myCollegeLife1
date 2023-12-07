@echo off
setlocal enabledelayedexpansion
for /f "delims=" %%i in ('dir %1/ad/t:c') do set t=%%i && (set year=!t:~6,4!) && echo !year!
echo max=%%2021%
echo min=%%2021%
pause