@echo off
setlocal enabledelayedexpansion
for /f "delims=" %%i in ('dir %1/ad/t:c') do set t=%%i && (set year=!t:~6,4!) && echo !year!
if !year! > 2021 to echo Max:2021
if !year! < 2021 to echo min 2020
pause