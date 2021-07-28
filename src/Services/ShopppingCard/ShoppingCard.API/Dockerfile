#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Services/ShopppingCard/ShoppingCard.API/ShoppingCard.API.csproj", "src/Services/ShopppingCard/ShoppingCard.API/"]
COPY ["src/Services/ShopppingCard/Domain/ShoppincCard.Domain/ShoppincCard.Domain.csproj", "src/Services/ShopppingCard/Domain/ShoppincCard.Domain/"]
RUN dotnet restore "src/Services/ShopppingCard/ShoppingCard.API/ShoppingCard.API.csproj"
COPY . .
WORKDIR "/src/src/Services/ShopppingCard/ShoppingCard.API"
RUN dotnet build "ShoppingCard.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingCard.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingCard.API.dll"]
