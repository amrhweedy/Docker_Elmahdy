
# build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /src
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o output

# final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /src/output .
ENTRYPOINT ["dotnet", "WebDocker.dll"]


# use this command to make container >> docker run --name <container-name> -d -p <portinmydevice>:8080 <image-name>

