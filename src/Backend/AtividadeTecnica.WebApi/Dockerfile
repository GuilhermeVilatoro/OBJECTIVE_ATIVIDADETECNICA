FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Backend/AtividadeTecnica.Exercicios/AtividadeTecnica.WebApi/AtividadeTecnica.WebApi.csproj", "src/Backend/AtividadeTecnica.Exercicios/AtividadeTecnica.WebApi/"]
RUN dotnet restore "src/Backend/AtividadeTecnica.Exercicios/AtividadeTecnica.WebApi/AtividadeTecnica.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Backend/AtividadeTecnica.Exercicios/AtividadeTecnica.WebApi"
RUN dotnet build "AtividadeTecnica.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AtividadeTecnica.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AtividadeTecnica.WebApi.dll"]