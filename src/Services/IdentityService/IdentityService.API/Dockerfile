#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

#IdentityService.Persistance
COPY ["src/Services/IdentityService/IdentityService.API/IdentityService.Persistance.csproj", "src/Services/IdentityService/IdentityService.Persistance/"]
#IdentityService.Domain
COPY ["src/Services/IdentityService/IdentityService.Domain/IdentityService.Domain.csproj", "src/Services/IdentityService/IdentityService.Domain/"]
#IdentityService.Application
COPY ["src/Services/IdentityService/IdentityService.API/IdentityService.Application.csproj", "src/Services/IdentityService/IdentityService.Application/"]
#API
COPY ["src/Services/IdentityService/IdentityService.API/IdentityService.API.csproj", "src/Services/IdentityService/IdentityService.API/"]

RUN dotnet restore "src/Services/IdentityService/IdentityService.API/IdentityService.API.csproj"
COPY . .
WORKDIR "/src/src/Services/IdentityService/IdentityService.API"
RUN dotnet build "IdentityService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityService.API.dll"]