FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Anchorage.Server/Anchorage.Server.csproj", "Anchorage.Server/"]
COPY ["Anchorage.Shared/Anchorage.Shared.csproj", "Anchorage.Shared/"]
RUN dotnet restore "Anchorage.Server/Anchorage.Server.csproj"
COPY . .
WORKDIR "/src/Anchorage.Server"
RUN dotnet build "Anchorage.Server.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Anchorage.Server.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Anchorage.Server.dll"]