# alib

# App stack:

OS: Ubuntu 24.04 LTS on DigitalOcean droplet

Web server: Nginx 1.26.0 (reverse proxy + SSL via Let’s Encrypt)

Runtime: .NET 8.0 (ASP.NET Core, Blazor, ServiceStack 8)

ORMs: EF Core (SQLite) + ServiceStack.OrmLite (SQLite)

Front-end: Vue 3 + ServiceStack-Vue + Tailwind CSS + static assets in wwwroot

Database: SQLite file (/var/www/cmmydb/App_Data/app.db)

Deployment: published via dotnet publish, SCP’d to /var/www/cmmydb, run under systemd
