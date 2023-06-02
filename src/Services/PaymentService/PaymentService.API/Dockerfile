#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

#CorePayment.Domain
COPY ["src/Services/PaymentService/Core.Payment/CorePayment.Domain/CorePayment.Domain.csproj", "src/Services/PaymentService/Core.Payment/"]
#CorePayment.Persistance
COPY ["src/Services/PaymentService/Core.Payment/CorePayment.Persistance/CorePayment.Persistance.csproj", "src/Services/PaymentService/Core.Payment/"]
#PaymentService.Persistance
COPY ["src/Services/PaymentService/PaymentService.API/PaymentService.Persistance.csproj", "src/Services/PaymentService/PaymentService.Persistance/"]
#PaymentService.Domain
COPY ["src/Services/PaymentService/PaymentService.Domain/PaymentService.Domain.csproj", "src/Services/PaymentService/PaymentService.Domain/"]
#PaymentService.Application
COPY ["src/Services/PaymentService/PaymentService.API/PaymentService.Application.csproj", "src/Services/PaymentService/PaymentService.Application/"]
#API
COPY ["src/Services/PaymentService/PaymentService.Application/PaymentService.API.csproj", "src/Services/PaymentService/PaymentService.API/"]

RUN dotnet restore "src/Services/PaymentService/PaymentService.API/PaymentService.API.csproj"
COPY . .
WORKDIR "/src/src/Services/PaymentService/PaymentService.API"
RUN dotnet build "PaymentService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentService.API.dll"]