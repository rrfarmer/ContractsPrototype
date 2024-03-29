# Get Base Image (Full .NET Core SDK)
# FROM mcr.microsoft.com/dotnet/core/sdk:5.0 AS build-env
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Generate runtime image
# FROM mcr.microsoft.com/dotnet/core/sdk:5.0
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 5001
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Prototype.dll"]