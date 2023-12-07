@echo off
setlocal enabledelayedexpansion
for /f "delims=" %%i in ('dir %1/ad/t:c') do set t=%%i && (set year=!t:~6,4!) && echo !year!
 for /f "tokens=1* delims=]" %%a in ('
  find /v /n "" ^<"%infile%"^& type nul^>"%outfile%"
 ') do (
  if not "%%b"=="" (set line=%%b) else (set line=not)
  set "newline=!line:%~1=%~2!"
  set newline=!newline:not=!
  echo.!newline!>>"%outfile%"
pause
 )
