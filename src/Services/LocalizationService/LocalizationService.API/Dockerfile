#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Services/LocalizationService/LocalizationService.API/LocalizationService.API.csproj", "src/Services/LocalizationService/LocalizationService.API/"]
RUN dotnet restore "src/Services/LocalizationService/LocalizationService.API/LocalizationService.API.csproj"
COPY . .
WORKDIR "/src/src/Services/LocalizationService/LocalizationService.API"
RUN dotnet build "LocalizationService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LocalizationService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LocalizationService.API.dll"]