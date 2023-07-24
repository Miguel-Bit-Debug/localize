#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Localize.API/Localize.API.csproj", "Localize.API/"]
COPY ["Localize.CrossCutting/Localize.CrossCutting.csproj", "Localize.CrossCutting/"]
COPY ["Localize.InfraData/Localize.InfraData.csproj", "Localize.InfraData/"]
COPY ["Localize.Domain/Localize.Domain.csproj", "Localize.Domain/"]
RUN dotnet restore "Localize.API/Localize.API.csproj"
COPY . .
WORKDIR "/src/Localize.API"
RUN dotnet build "Localize.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Localize.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Localize.API.dll"]