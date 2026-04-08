# Estágio base usando o runtime do ASP.NET Core 10.0
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
# A plataforma em nuvem (Render, Railway, etc.) injeta dinamicamente a porta através da variável PORT. 
# Exporemos a porta padrão 8080 que o .NET 8/10 usa pro padrão em contêineres e na configuração de deploy.
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Estágio de construção usando o SDK do .NET 10.0
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copiar o csproj e restaurar as dependências via Nuget
COPY ["DevPortfolio.csproj", "./"]
RUN dotnet restore "DevPortfolio.csproj"

# Copiar todo o resto do projeto
COPY . .
RUN dotnet build "DevPortfolio.csproj" -c Release -o /app/build

# Publicação (gerando a build final otimizada)
FROM build AS publish
RUN dotnet publish "DevPortfolio.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Estágio de Produção (Imagem limpa e leve só com o código rodando)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevPortfolio.dll"]
