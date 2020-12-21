If you want to change database configuration, please open appsettings.json,
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "DefaultConnection": {
    "ConnectionString": "server=localhost;user=root;password=password;database=studi_kasus"
  }
}
```
```
For migrations
dotnet ef update database
build and run

dotnet build
dotnet run
```