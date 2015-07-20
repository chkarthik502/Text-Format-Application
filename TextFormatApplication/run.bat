@ECHO OFF	
REM 
cd C:\Program Files\Microsoft Visual Studio 11.0
cd %~dp0
nant
"PAUSE"
cd ./build/TextFormatTestLib.dll-results.txt
cd ./build/coverage/index.htm
REM End of code;

cd %~dp0
notepad .\build\TextFormatTestLib.dll-results.txt

start chrome.exe %~dp0\build\coverage\index.htm