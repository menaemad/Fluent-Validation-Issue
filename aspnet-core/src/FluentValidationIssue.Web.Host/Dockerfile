FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/FluentValidationIssue.Web.Host/FluentValidationIssue.Web.Host.csproj", "src/FluentValidationIssue.Web.Host/"]
COPY ["src/FluentValidationIssue.Web.Core/FluentValidationIssue.Web.Core.csproj", "src/FluentValidationIssue.Web.Core/"]
COPY ["src/FluentValidationIssue.Application/FluentValidationIssue.Application.csproj", "src/FluentValidationIssue.Application/"]
COPY ["src/FluentValidationIssue.Core/FluentValidationIssue.Core.csproj", "src/FluentValidationIssue.Core/"]
COPY ["src/FluentValidationIssue.EntityFrameworkCore/FluentValidationIssue.EntityFrameworkCore.csproj", "src/FluentValidationIssue.EntityFrameworkCore/"]
WORKDIR "/src/src/FluentValidationIssue.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FluentValidationIssue.Web.Host", "src/FluentValidationIssue.Web.Host"]
COPY ["src/FluentValidationIssue.Web.Core", "src/FluentValidationIssue.Web.Core"]
COPY ["src/FluentValidationIssue.Application", "src/FluentValidationIssue.Application"]
COPY ["src/FluentValidationIssue.Core", "src/FluentValidationIssue.Core"]
COPY ["src/FluentValidationIssue.EntityFrameworkCore", "src/FluentValidationIssue.EntityFrameworkCore"]
WORKDIR "/src/src/FluentValidationIssue.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FluentValidationIssue.Web.Host.dll"]
