https://www.entityframeworktutorial.net/efcore/pmc-commands-for-ef-core-migration.aspx

Remove-Migration -Force -Context DatabaseContext
Add-Migration -Name Initialize -Context DatabaseContext
Update-Database
Update-Database -Context DatabaseContext -Project ATNetCoreTelegramBot.Models -StartupProject ATNetCoreTelegramBot.Models