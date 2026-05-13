# Changelog

## [2.6.13] - 2026-05-13

- Regenerated against Apigen.Generator 2.3.0.
- All operations and interfaces now accept `CancellationToken cancellationToken = default` and propagate it through HTTP calls and content reads.
- Non-success responses now throw `ApiException` (inherits from `HttpRequestException`) exposing `StatusCode`, `Method`, `Url`, `ResponseBody`, `Headers`, and `ContentHeaders`. Existing `catch (HttpRequestException)` callers continue to work.
- Improved logging: distinct events for caller cancellation (Debug, 1004), `HttpClient.Timeout` (Error, 3002), transport failures (Error, 3003), and API errors (Error, 3001).

## [2.6.0] - 2026-03-24

- Initial open-source release
- Generated C# client for Immich API
