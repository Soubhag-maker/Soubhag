# Use the official Microsoft .NET Core 2.2 runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app

# Use the official .NET Core 2.2 SDK image to build the application
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["SOUBHAG/SOUBHAG.csproj", "SOUBHAG/"]
WORKDIR "/src/SOUBHAG"
RUN dotnet restore "SOUBHAG.csproj"

# Copy the entire source and build the application
COPY . . 
RUN dotnet publish "SOUBHAG.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SOUBHAG.dll"]
