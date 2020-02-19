FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 

WORKDIR /app

COPY SampleApp/ .
RUN dotnet restore
RUN dotnet build -c Release -o out
ENTRYPOINT ["/app/out/SampleApp.exe"]
