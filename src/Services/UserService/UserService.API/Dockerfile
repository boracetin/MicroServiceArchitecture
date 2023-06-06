#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
#CoreUser.Domain
COPY ["src/Services/UserService/Core.User/CoreUser.Domain/CoreUser.Domain.csproj", "src/Services/UserService/Core.User/"]
#CoreUser.Persistance
COPY ["src/Services/UserService/Core.Edition/CoreUser.Persistance/CoreUser.Persistance.csproj", "src/Services/UserService/Core.User/"]
#UserService.Persistance
COPY ["src/Services/UserService/UserService.API/UserService.Persistance.csproj", "src/Services/UserService/UserService.Persistance/"]
#UserService.Domain
COPY ["src/Services/UserService/UserService.Domain/UserService.Domain.csproj", "src/Services/UserService/UserService.Domain/"]
#UserService.Application
COPY ["src/Services/UserService/UserService.API/UserService.Application.csproj", "src/Services/UserService/UserService.Application/"]
#API
COPY ["src/Services/UserService/UserService.API/UserService.API.csproj", "src/Services/UserService/UserService.API/"]
RUN dotnet restore "src/Services/UserService/UserService.API/UserService.API.csproj"
COPY . .
WORKDIR "/src/src/Services/UserService/UserService.API"
RUN dotnet build "UserService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserService.API.dll"]