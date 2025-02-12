# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /HospitalManagementSystem

# Copy everything and restore dependencies
COPY . ./
RUN dotnet restore

# Build and publish the app
RUN dotnet publish -c Release -o /publish

# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /HospitalManagementSystem

# Copy the built app from the previous stage
COPY --from=build /publish .

# Expose the necessary port
EXPOSE 5000

# Start the application
CMD ["dotnet", "HospitalManagementSystem.dll"]
