
if %errorlevel% neq 0 (
  echo %errorlevel%
  exit /b 10
)

BCDEdit /set PAE forceenable Windows
bcdedit /set increaseuserva 3072
shutdown -r -t 0
