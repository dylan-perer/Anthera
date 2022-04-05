#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Get sdk image from mircosoft
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /src

#Copy project and restore dependecies.
COPY *.csproj ./
RUN dotnet restore

#Copy the project files and build our container
COPY ../
RUN dotnet publish -c Realease -o out


#Generate runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /src
EXPOSE 80
COPY --from=publish /app/out .
ENTRYPOINT ["dotnet", "Anthera.dll"]

