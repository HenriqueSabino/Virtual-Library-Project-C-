# Depending on the .NET version you might need to specify the version
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["VirtualLibrary.csproj", "./"]
RUN dotnet restore "VirtualLibrary.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "VirtualLibrary.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VirtualLibrary.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VirtualLibrary.dll"]