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
dotnet ef database update

build and run
dotnet build
dotnet run
```

For migration will take about 3-8 minutes
