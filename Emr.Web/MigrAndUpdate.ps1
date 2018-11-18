[string]$nameMigr = $( Read-Host "Input Name Migr" )

 Write-Output ("Name of migr:"+$nameMigr)
dotnet ef migrations add $nameMigr -o ./Migrations 
dotnet ef database update