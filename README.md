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
The below code can be used in a .NET Core project, a test project is also included in the GitHub solution.

```C#
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create client
            MetOfficeDataPointClient client = new MetOfficeDataPointClient("[TOKEN}");

            // Get all sites
            SiteListResponse siteListResponse = client.GetAllSites().Result;

            // Get available forcasts
            AvailableTimeStampsResponse availableTimeStampsResponse = client.GetAvailableTimestamps().Result;

            // Get all 3 hourly forecasts
            ForecastResponse3Hourly forecastResponse3Hourly = client.GetForecasts3Hourly().Result;

            // Get daily forecasts for site 14
            ForecastResponseDaily forecastResponseDaily = client.GetForecastsDaily(14).Result;

            // Get historical observations
            ForecastResponse3Hourly historicalResponse = client.GetHistoricalObservations().Result;

            // Get closest site
            GeoCoordinate coordinate = new GeoCoordinate(51.508363, -0.163006);
            Location location = client.GetClosestSite(coordinate).Result;
        }
    }
```
# Example
See <a href="https://bitscry.com/Projects/Weather" alt="bitscry weather">here</a> for an example of this in action with the weather status matched to corresponding <a href="https://erikflowers.github.io/weather-icons/" alt="weather icons">weather icons</a>.
