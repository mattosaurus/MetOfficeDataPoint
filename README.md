# MetOfficeDataPoint
.NET wrapper to query the Met Office DataPoint API for weather data.

# Installation
To use MetOfficeDataPoint in your C# project, you can either download the MetOfficeDataPoint C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package MetOfficeDataPoint
```
Once you have the MetOfficeDataPoint libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using MetOfficeDataPoint;
using MetOfficeDataPoint.Models;
using MetOfficeDataPoint.Models.GeoCoordinate;
```

# Usage
The client is intended to be used via Dependency Injection and added using the `AddMetOfficeDataPointService` extension.

```C#
// Add API client
serviceCollection.AddMetOfficeDataPointService(
    "<API KEY>"
    );
```

The injected client can then be used as expected.

```C#
public class App
{
    private readonly ILogger<App> _logger;
    private readonly IMetOfficeDataPointService _metOfficeDataPointService;

    public App(ILoggerFactory loggerFactory, IMetOfficeDataPointService metOfficeDataPointService)
    {
        _logger = loggerFactory.CreateLogger<App>();
        _metOfficeDataPointService = metOfficeDataPointService;
    }

    public async Task RunAsync()
    {
        // Get all sites
        SiteListResponse siteListResponse = await _metOfficeDataPointService.GetAllSitesAsync();

        // Get available forcasts
        AvailableTimeStampsResponse availableTimeStampsResponse = await _metOfficeDataPointService.GetAvailableTimestampsAsync();

        // Get all 3 hourly forecasts
        ForecastResponse3Hourly forecastResponse3Hourly = await _metOfficeDataPointService.GetForecasts3HourlyAsync();

        // Get daily forecasts for site 14
        ForecastResponseDaily forecastResponseDaily = await _metOfficeDataPointService.GetForecastsDailyAsync(14);

        // Get historical observations
        ForecastResponse3Hourly historicalResponse = await _metOfficeDataPointService.GetHistoricalObservationsAsync();

        // Get closest site
        GeoCoordinate coordinate = new GeoCoordinate(51.508363, -0.163006);
        Location location = await _metOfficeDataPointService.GetClosestSiteAsync(coordinate);
    }
}
```

See the [debug project](https://github.com/mattosaurus/MetOfficeDataPoint/tree/master/MetOfficeDataPoint.Debug) for an example.
