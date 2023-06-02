#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
#CoreTenant.Domain
COPY ["src/Services/TenantService/Core.Tenant/CoreTenant.Domain/CoreTenant.Domain.csproj", "src/Services/TenantService/Core.Tenant/"]
#CoreTenant.Persistance
COPY ["src/Services/TenantService/Core.Tenant/CoreTenant.Persistance/CoreTenant.Persistance.csproj", "src/Services/TenantService/Core.Tenant/"]
#TenantService.Persistance
COPY ["src/Services/TenantService/TenantService.API/TenantService.Persistance.csproj", "src/Services/TenantService/TenantService.Persistance/"]
#TenantService.Domain
COPY ["src/Services/TenantService/TenantService.Domain/TenantService.Domain.csproj", "src/Services/TenantService/TenantService.Domain/"]
#TenantService.Application
COPY ["src/Services/TenantService/TenantService.API/TenantService.Application.csproj", "src/Services/TenantService/TenantService.Application/"]
#API
COPY ["src/Services/TenantService/TenantService.Application/TenantService.API.csproj", "src/Services/TenantService/TenantService.API/"]
RUN dotnet restore "src/Services/TenantService/TenantService.API/TenantService.API.csproj"
COPY . .
WORKDIR "/src/src/Services/TenantService/TenantService.API"
RUN dotnet build "TenantService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TenantService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TenantService.API.dll"]