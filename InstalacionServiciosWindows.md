Para instalar un servicio de windows:
Por PowerShell:
New-Service -Name "SendMail" -BinaryPathName RutaDelEjecutable

Para desinstalar un servicio de windows:
Por CMD:
sc delete NombreDeServicio
