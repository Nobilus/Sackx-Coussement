FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Project.csproj", "./"]
RUN dotnet restore "Project.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY /SeedData/klanten.csv /app/SeedData/
COPY /SeedData/producten.csv /app/SeedData/
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project.dll"]