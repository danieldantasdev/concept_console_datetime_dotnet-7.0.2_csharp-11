FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Date/Date.csproj", "Date/"]
RUN dotnet restore "Date/Date.csproj"
COPY . .
WORKDIR "/src/Date"
RUN dotnet build "Date.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Date.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Date.dll"]
