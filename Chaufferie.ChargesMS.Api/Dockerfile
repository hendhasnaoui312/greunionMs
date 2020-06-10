FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Chaufferie.ChargesMS.Api/Chaufferie.ChargesMS.Api.csproj", "Chaufferie.ChargesMS.Api/"]
COPY ["Chaufferie.ChargesMS.Infra.IoC/Chaufferie.ChargesMS.Infra.IoC.csproj", "Chaufferie.ChargesMS.Infra.IoC/"]
COPY ["Chaufferie.ChargesMS.Domain/Chaufferie.ChargesMS.Domain.csproj", "Chaufferie.ChargesMS.Domain/"]
COPY ["Chaufferie.ChargeMS.Data/Chaufferie.ChargeMS.Data.csproj", "Chaufferie.ChargeMS.Data/"]
RUN dotnet restore "Chaufferie.ChargesMS.Api/Chaufferie.ChargesMS.Api.csproj"
COPY . .
WORKDIR "/src/Chaufferie.ChargesMS.Api"
RUN dotnet build "Chaufferie.ChargesMS.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chaufferie.ChargesMS.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chaufferie.ChargesMS.Api.dll"]