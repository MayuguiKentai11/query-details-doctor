FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID

# Set environment variables and work directory
WORKDIR /app

EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000
ARG ASPNETCORE_ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["RecipesDoctor.API/RecipesDoctor.API.csproj", "RecipesDoctor.API/"]
RUN dotnet restore "RecipesDoctor.API/RecipesDoctor.API.csproj"

# Copy the remaining source code and build the application
COPY . .
WORKDIR "/src/RecipesDoctor.API"
RUN dotnet build "RecipesDoctor.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "RecipesDoctor.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false


# Use the base image for the final stage
FROM base AS final
WORKDIR /app

# Copy the published output from the build stage
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "RecipesDoctor.API.dll"]
