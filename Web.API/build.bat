@ECHO OFF
SETLOCAL

REM EXAMPLE Usage: .\Web.API\build.bat 0.1.0.1 Y API-#####################

SET VERSION=%1
SET PUSH=%2
SET BASEPATH=c:\Temp\Web.Api.Published
SET API=%3


ECHO "Removing & Creating Output Directory"
IF EXIST "%BASEPATH%" (	rmdir %BASEPATH% /s /q )
IF ERRORLEVEL 1 GOTO Error
mkdir "%BASEPATH%"
IF ERRORLEVEL 1 GOTO Error

dotnet publish .\Web.API\Web.API.csproj --output "%BASEPATH%" --configuration Release

.\Octo.exe pack --id Web.TORCHx.Core.Web.API --version "%VERSION%" --basePath "%BASEPATH%" --outFolder="%BASEPATH%"

IF '%PUSH%'=='Y' .\Octo.exe push --package %BASEPATH%\Web.TORCHx.Core.Web.API.%VERSION%.nupkg --server https://deploy.web.com/ --apiKey %3


ECHO Complete
GOTO End
:Error
ECHO ERROR..

:End

ENDLOCAL