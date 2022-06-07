# SOAP

- https://github.com/DigDes/SoapCore#getting-started

```
dotnet new webapi -o src/MyService
```

# Client

```
dotnet new tool-manifest
dotnet tool install dotnet-svcutil
```

# Generate client

```
dotnet new console -o src/MyClient
dotnet svcutil http://localhost:5116/Service.asmx --projectFile src/MyClient/MyClient.csproj
```

# Restore

```
dotnet tool restore
```