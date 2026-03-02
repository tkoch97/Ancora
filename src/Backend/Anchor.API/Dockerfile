# Acesse https://aka.ms/customizecontainer para saber como personalizar seu contêiner de depuração e como o Visual Studio usa este Dockerfile para criar suas imagens para uma depuração mais rápida.

# Esta fase é usada durante a execução no VS no modo rápido (Padrão para a configuração de Depuração)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Esta fase é usada para compilar o projeto de serviço
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Backend/Anchor.API/Anchor.API.csproj", "src/Backend/Anchor.API/"]
COPY ["src/Backend/Anchor.Application/Anchor.Application.csproj", "src/Backend/Anchor.Application/"]
COPY ["src/Backend/Anchor.Domain/Anchor.Domain.csproj", "src/Backend/Anchor.Domain/"]
COPY ["src/Backend/Anchor.Infrastructure/Anchor.Infrastructure.csproj", "src/Backend/Anchor.Infrastructure/"]

RUN dotnet restore "./src/Backend/Anchor.API/Anchor.API.csproj"
COPY . .
WORKDIR "/src/Backend/Anchor.API"
RUN dotnet build "./src/Backend/Anchor.API/Anchor.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Esta fase é usada para publicar o projeto de serviço a ser copiado para a fase final
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Anchor.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Esta fase é usada na produção ou quando executada no VS no modo normal (padrão quando não está usando a configuração de Depuração)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Anchor.API.dll"]