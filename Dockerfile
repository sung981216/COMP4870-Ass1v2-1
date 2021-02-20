FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
EXPOSE 443/tcp
ENTRYPOINT ["dotnet", "assignment01.dll"]
