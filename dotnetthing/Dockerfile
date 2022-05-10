FROM mcr.microsoft.com/dotnet/sdk:6.0 as builder
WORKDIR /app
COPY dotnetthing.csproj ./
# dotnet restore pulls down the nuget packages via csproj
RUN dotnet restore 
# copy everything else (unless it is the .dockerignore file or .gitignore file)
COPY . ./
# dotnet publish creates a release inside bin folder
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:6.0.5 as runtime
WORKDIR /app
COPY --from=builder /app/out .
ENTRYPOINT ["dotnet", "dotnetthing.dll"]