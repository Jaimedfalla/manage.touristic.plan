#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Manage.Touristic.Plan.Api/Manage.Touristic.Plan.Api.csproj", "Manage.Touristic.Plan.Api/"]
COPY ["Manage.Touristic.Plan.Application.DTO/Manage.Touristic.Plan.Application.DTO.csproj", "Manage.Touristic.Plan.Application.DTO/"]
COPY ["Manage.Touristic.Plan.Application.Interface/Manage.Touristic.Plan.Application.Interface.csproj", "Manage.Touristic.Plan.Application.Interface/"]
COPY ["Manage.Touristic.Plan.Transversal.Common/Manage.Touristic.Plan.Transversal.Common.csproj", "Manage.Touristic.Plan.Transversal.Common/"]
COPY ["Manage.Touristic.Plan.Application.Main/Manage.Touristic.Plan.Application.Main.csproj", "Manage.Touristic.Plan.Application.Main/"]
COPY ["Manage.Touristic.Plan.Domain.Entities/Manage.Touristic.Plan.Domain.Entities.csproj", "Manage.Touristic.Plan.Domain.Entities/"]
COPY ["Manage.Touristic.Plan.Domain.Interface/Manage.Touristic.Plan.Domain.Interface.csproj", "Manage.Touristic.Plan.Domain.Interface/"]
COPY ["Manage.Touristic.Plan.Domain.Core/Manage.Touristic.Plan.Domain.Core.csproj", "Manage.Touristic.Plan.Domain.Core/"]
COPY ["Manage.Touristic.Plan.Infraestructure.Interface/Manage.Touristic.Plan.Infraestructure.Interface.csproj", "Manage.Touristic.Plan.Infraestructure.Interface/"]
COPY ["Manage.Touristic.Plan.Infraestructure.Data/Manage.Touristic.Plan.Infraestructure.Data.csproj", "Manage.Touristic.Plan.Infraestructure.Data/"]
COPY ["Manage.Touristic.Plan.Infraestructure.Repositories/Manage.Touristic.Plan.Infraestructure.Repositories.csproj", "Manage.Touristic.Plan.Infraestructure.Repositories/"]
COPY ["Manage.Touristic.Plan.Transversal.Mapper/Manage.Touristic.Plan.Transversal.Mapper.csproj", "Manage.Touristic.Plan.Transversal.Mapper/"]
RUN dotnet restore "Manage.Touristic.Plan.Api/Manage.Touristic.Plan.Api.csproj"
COPY . .
WORKDIR "/src/Manage.Touristic.Plan.Api"
RUN dotnet build "Manage.Touristic.Plan.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Manage.Touristic.Plan.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Manage.Touristic.Plan.Api.dll"]