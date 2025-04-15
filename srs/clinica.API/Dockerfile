#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["srs/clinica.API/clinica.API.csproj", "srs/clinica.API/"]
COPY ["src/clinica.Infrastructure/clinica.Infrastructure.csproj", "src/clinica.Infrastructure/"]
COPY ["srs/clinica.Domain/clinica.Domain.csproj", "srs/clinica.Domain/"]
COPY ["srs/clinica.Application/clinica.Application.csproj", "srs/clinica.Application/"]
COPY ["srs/clinica.Communication/clinica.Communication.csproj", "srs/clinica.Communication/"]
COPY ["srs/clinica.Exception/clinica.Exception.csproj", "srs/clinica.Exception/"]
RUN dotnet restore "./srs/clinica.API/clinica.API.csproj"
COPY . .
WORKDIR "/src/srs/clinica.API"
RUN dotnet build "./clinica.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./clinica.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "clinica.API.dll"]