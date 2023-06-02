#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443





FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
#CoreEdition.Domain
COPY ["src/Services/EditionService/Core.Edition/CoreEdition.Domain/CoreEdition.Domain.csproj", "src/Services/EditionService/Core.Edition/"]
#CoreEdition.Persistance
COPY ["src/Services/EditionService/Core.Edition/CoreEdition.Persistance/CoreEdition.Persistance.csproj", "src/Services/EditionService/Core.Edition/"]
#EditionService.Persistance
COPY ["src/Services/EditionService/EditionService.API/EditionService.Persistance.csproj", "src/Services/EditionService/EditionService.Persistance/"]
#EditionService.Domain
COPY ["src/Services/EditionService/EditionService.Domain/EditionService.Domain.csproj", "src/Services/EditionService/EditionService.Domain/"]
#EditionService.Application
COPY ["src/Services/EditionService/EditionService.API/EditionService.Application.csproj", "src/Services/EditionService/EditionService.Application/"]
#API
COPY ["src/Services/EditionService/EditionService.Application/EditionService.API.csproj", "src/Services/EditionService/EditionService.API/"]
RUN dotnet restore "src/Services/EditionService/EditionService.API/EditionService.API.csproj"
COPY . .
WORKDIR "/src/src/Services/EditionService/EditionService.API"
RUN dotnet build "EditionService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EditionService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EditionService.API.dll"]