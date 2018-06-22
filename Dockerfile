FROM microsoft/dotnet:2.1.301-sdk as build-env
WORKDIR app
COPY . ./
RUN dotnet publish --configuration Release -o ./publish
