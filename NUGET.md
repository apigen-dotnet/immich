# Apigen.Immich

Generated C# client for the [Immich](https://immich.app/) photo management API.

## Installation

```bash
dotnet add package Apigen.Immich.Client
```

## Usage

```csharp
using Apigen.Immich.Client;
using Apigen.Immich.Models;

// Create client with API key
var client = ImmichApiClient.WithApiKey(
    "your-api-key",
    "https://your-immich-instance/api");

// Or with Bearer token (JWT)
var client = ImmichApiClient.WithBearer(
    "your-jwt-token",
    "https://your-immich-instance/api");

// Or with cookie-based session
var client = ImmichApiClient.WithCookie(
    "session-token",
    "https://your-immich-instance/api");

// Or use a pre-configured HttpClient
var client = new ImmichApiClient(httpClient);
```

## License

MIT
