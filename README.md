# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Creacion de la solucion y proyecto

* dotnet new sln -n Placica.Core
* dotnet new webapi -o "2. Distribution/Placica.Core.WebAPI" -n Placica.Core.WebAPI -f netcoreapp3.1
* dotnet new classlib -o "3. Application/Placica.Core.Contracts.ServiceLibrary" -n Placica.Core.Contracts.ServiceLibrary -f netcoreapp3.1
* dotnet new classlib -o "3. Application/Placica.Core.Impl.ServiceLibrary" -n Placica.Core.Impl.ServiceLibrary -f netcoreapp3.1
* dotnet new classlib -o "4. Domain/Placica.Core.Library" -n Placica.Core.Library -f netcoreapp3.1
* dotnet new classlib -o "5. Infraestructure/Placica.Core.Infraestructure.Data" -n Placica.Core.Infraestructure.Data -f netcoreapp3.1

* dotnet sln Placica.Core.sln add 2.\ Distribution/Placica.Core.WebAPI
* dotnet sln Placica.Core.sln add 3.\ Application/Placica.Core.Contracts.ServiceLibrary/
* dotnet sln Placica.Core.sln add 3.\ Application/Placica.Core.Impl.ServiceLibrary/
* dotnet sln Placica.Core.sln add 4.\ Domain/Placica.Core.Library/
* dotnet sln Placica.Core.sln add 5.\ Infraestructure/Placica.Core.Infraestructure.Data/

* dotnet add 5.\ Infraestructure/Placica.Core.Infraestructure.Data/ reference 4.\ Domain/Placica.Core.Library/
* dotnet add 3.\ Application/Placica.Core.Impl.ServiceLibrary/ reference 4.\ Domain/Placica.Core.Library/
* dotnet add 3.\ Application/Placica.Core.Impl.ServiceLibrary/ reference 3.\ Application/Placica.Core.Contracts.ServiceLibrary/
* dotnet add 2.\ Distribution/Placica.Core.WebAPI reference 3.\ Application/Placica.Core.Contracts.ServiceLibrary/
* dotnet add 2.\ Distribution/Placica.Core.WebAPI reference 3.\ Application/Placica.Core.Impl.ServiceLibrary/
* dotnet add 2.\ Distribution/Placica.Core.WebAPI reference 5.\ Infraestructure/Placica.Core.Infraestructure.Data/
 
* dotnet build
* dotnet run -p 2.\ Distribution/Placica.Core.WebAPI/

* dotnet add 2.\ Distribution/Placica.Core.WebAPI/ package Microsoft.EntityFrameworkCore.Design

# Serilog
* https://www.campusmvp.es/recursos/post/como-manejar-trazas-en-net-core-con-serilog.aspx

# JWT
* https://jasonwatmore.com/post/2019/10/11/aspnet-core-3-jwt-authentication-tutorial-with-example-api

# Validation
* https://docs.fluentvalidation.net/en/latest/start.html

# SqlLite 
* https://elanderson.net/2019/11/asp-net-core-3-add-entity-framework-core-to-existing-project/
* dotnet ef migrations add Initial -o Data/SqlliteMigrations --project 2.\ Distribution/Placica.Core.WebAPI/
* dotnet ef database update --project 2.\ Distribution/Placica.Core.WebAPI/
* Done. To undo this action, use 'ef migrations remove'

1) dotnet ef database drop --project 2.\ Distribution/Placica.Core.WebAPI/
2) dotnet ef migrations remove --project 2.\ Distribution/Placica.Core.WebAPI/
3) dotnet ef migrations add Initial --project 2.\ Distribution/Placica.Core.WebAPI/
4) dotnet ef database update --project 2.\ Distribution/Placica.Core.WebAPI/

5) dotnet ef migrations add MigrateParametrosInitial  --project 2.\ Distribution/Placica.Core.WebAPI/

# Docker
* Docker % docker pull mysql:latest
* docker run -p 3307:3306 --name mysql -e MYSQL_ROOT_PASSWORD=root -d mysql 

* docker pull redis:latest
* docker run -p 6379:6379 --name ps-redis -d redis

https://codehandbook.org/how-to-connect-to-mysql-running-in-docker-container-from-localhost/

https://github.com/thepirat000/Audit.NET
https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Redis/README.md

https://gavilan.blog/2019/08/04/audit-by-columns-with-entity-framework-core/