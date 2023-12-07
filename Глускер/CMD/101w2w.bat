@echo off
setlocal enabledelayedexpansion
for /f "delims=" %%i in ('dir %1/ad/t:c') do set t=%%i && (set year=!t:~6,4!) && echo !year!
set max=%i%
if %i% GTR %max% set max=%i%
set min=%i%
if %i% LSS %min% set min=%i%
echo min
echo max
pause