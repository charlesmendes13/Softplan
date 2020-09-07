#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://0.0.0.0:5002
EXPOSE 5002

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Api2/Softplan.Api2/Softplan.Api2.csproj", "src/Api2/Softplan.Api2/"]
RUN dotnet restore "src/Api2/Softplan.Api2/Softplan.Api2.csproj"
COPY . .
WORKDIR "/src/src/Api2/Softplan.Api2"
RUN dotnet build "Softplan.Api2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Softplan.Api2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Softplan.Api2.dll"]