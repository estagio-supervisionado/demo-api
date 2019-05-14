FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Demo.Api/Demo.Api.csproj", "src/Demo.Api/"]
RUN dotnet restore "src/Demo.Api/Demo.Api.csproj"
COPY . .
WORKDIR "/src/src/Demo.Api"
RUN dotnet build "Demo.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Demo.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Demo.Api.dll"]
