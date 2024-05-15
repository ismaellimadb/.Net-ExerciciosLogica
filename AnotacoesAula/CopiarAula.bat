@echo off
setlocal enabledelayedexpansion

rem Obter data atual
set "data=!date:~-4,4!!date:~-10,2!!date:~7,2!"

rem Obter hora atual
set "hora=!time:~0,2!!time:~3,2!!time:~6,2!"

rem Criar diretório com data e hora
mkdir "!data!!hora!"

rem Navegar para o diretório criado
cd "!data!!hora!"

rem Copiar a pasta inteira
xcopy /s /e /i "C:\Users\imlbl\OneDrive\Desktop\GitRepos\Curso-C#\AcompanharVidAula\" ".\"

endlocal