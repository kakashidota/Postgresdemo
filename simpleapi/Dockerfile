#base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443


# build image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src 
COPY ["simpleapi.csproj" , "."]
RUN dotnet restore "simpleapi.csproj"
COPY . .

# publish image
FROM build AS publish
RUN dotnet publish "simpleapi.csproj" -c Release -o /app/publish /p:UseAppHost=false

# final image
FROM base AS final
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "simpleapi.dll"]

