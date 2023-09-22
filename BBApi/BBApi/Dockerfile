#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BBApi/BBApi.csproj", "BBApi/"]
RUN dotnet restore "BBApi/BBApi.csproj"
COPY . .
WORKDIR "/src/BBApi"
RUN dotnet build "BBApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BBApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BBApi.dll"]