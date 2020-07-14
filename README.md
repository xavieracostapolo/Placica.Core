# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Creacion de la solucion y proyecto
dotnet new sln -n Placica.Core
dotnet new webapi -o "2. Distribution/Placica.Core.WebAPI" -n Placica.Core.WebAPI -f netcoreapp3.1
dotnet new classlib -o "3. Application/Placica.Core.Contracts.ServiceLibrary" -n Placica.Core.Contracts.ServiceLibrary -f netcoreapp3.1
dotnet new classlib -o "3. Application/Placica.Core.Impl.ServiceLibrary" -n Placica.Core.Impl.ServiceLibrary -f netcoreapp3.1
dotnet new classlib -o "4. Domain/Placica.Core.Library" -n Placica.Core.Library -f netcoreapp3.1
dotnet new classlib -o "5. Infraestructure/Placica.Core.Infraestructure.Data" -n Placica.Core.Infraestructure.Data -f netcoreapp3.1

dotnet sln Placica.Core.sln add 2.\ Distribution/Placica.Core.WebAPI
dotnet sln Placica.Core.sln add 3.\ Application/Placica.Core.Contracts.ServiceLibrary/
dotnet sln Placica.Core.sln add 3.\ Application/Placica.Core.Impl.ServiceLibrary/
dotnet sln Placica.Core.sln add 4.\ Domain/Placica.Core.Library/
dotnet sln Placica.Core.sln add 5.\ Infraestructure/Placica.Core.Infraestructure.Data/

dotnet add 5.\ Infraestructure/Placica.Core.Infraestructure.Data/ reference 4.\ Domain/Placica.Core.Library/
dotnet add 3.\ Application/Placica.Core.Impl.ServiceLibrary/ reference 4.\ Domain/Placica.Core.Library/
dotnet add 3.\ Application/Placica.Core.Impl.ServiceLibrary/ reference 3.\ Application/Placica.Core.Contracts.ServiceLibrary/
dotnet add 2.\ Distribution/Placica.Core.WebAPI reference 3.\ Application/Placica.Core.Contracts.ServiceLibrary/
dotnet add 2.\ Distribution/Placica.Core.WebAPI reference 3.\ Application/Placica.Core.Impl.ServiceLibrary/
dotnet add 2.\ Distribution/Placica.Core.WebAPI reference 5.\ Infraestructure/Placica.Core.Infraestructure.Data/

dotnet build
dotnet run -p 2.\ Distribution/Placica.Core.WebAPI/