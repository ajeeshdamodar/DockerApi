
#FROM microsoft/dotnet:latest
#
#WORKDIR /app
#COPY . .
#
#RUN dotnet restore
#
## run tests on docker build
#RUN dotnet test
#
## run tests on docker run
#ENTRYPOINT ["dotnet", "DockerApi.Test.dll"]


FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY DockerApi.Test/DockerApi.Test.csproj DockerApi.Test/
RUN dotnet restore DockerApi.Test/DockerApi.Test.csproj

# copy everything else and build
COPY . .
RUN dotnet test DockerApi.Test -c Release

# build runtime image
#FROM microsoft/dotnet:2.1-runtime
#WORKDIR /app
#COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "DockerApi.Test.dll"]
