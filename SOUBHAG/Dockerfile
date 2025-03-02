# Use the official Microsoft .NET Core 2.2 runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app

# Use the official .NET Core 2.2 SDK image to build the application
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src

# Correcting the path to the project file
COPY ["SOUBHAG/SOUBHAG.csproj", "SOUBHAG/"]
WORKDIR "/src/SOUBHAG"
RUN dotnet restore "SOUBHAG.csproj"

# Copy everything and build the app
COPY . .
WORKDIR "/src/SOUBHAG"
RUN dotnet publish "SOUBHAG.csproj" -c Release -o /app/publish

# Final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SOUBHAG.dll"]
