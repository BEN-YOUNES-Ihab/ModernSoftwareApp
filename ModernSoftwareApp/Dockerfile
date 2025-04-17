# Étape 1 : base image pour runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Étape 2 : build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copier tout le code source dans l’image
COPY . .

# Publier l’application en mode Release
RUN dotnet publish -c Release -o /app/publish

# Étape 3 : image finale
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Point d’entrée de l’application
ENTRYPOINT ["dotnet", "ModernSoftwareApp.dll"]
