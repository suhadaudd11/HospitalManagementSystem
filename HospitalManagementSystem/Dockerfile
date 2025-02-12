# Use the .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the solution and project files
COPY *.sln ./
COPY HospitalManagementSystem/*.csproj ./HospitalManagementSystem/

# Restore dependencies
RUN dotnet restore ./HospitalManagementSystem/HospitalManagementSystem.csproj

# Copy the rest of the project files
COPY . ./

# Build and publish the application
RUN dotnet publish ./HospitalManagementSystem/HospitalManagementSystem.csproj -c Release -o /publish

# Use the ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the built application
COPY --from=build /publish .

# Expose port 5000
EXPOSE 5000

# Start the application
CMD ["dotnet", "HospitalManagementSystem.dll"]
