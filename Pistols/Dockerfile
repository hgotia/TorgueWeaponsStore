FROM mcr.microsoft.com/dotnet/sdk:3.1
FROM mcr.microsoft.com/dotnet/aspnet:3.1

COPY /bin/Release/netcoreapp3.1/publish/ Pistols

ENV ASPNETCORE_ENVIRONMENT Production

EXPOSE 5000
WORKDIR /Pistols
ENTRYPOINT ["dotnet", "Pistols.dll", "--urls://0.0.0.0:5000"]