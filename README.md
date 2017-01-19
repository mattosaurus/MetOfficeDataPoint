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
```
# Dependencies
A DataPoint account and API key are required for use, registration is free and can be done <a href="http://www.metoffice.gov.uk/datapoint/" alt="Met Office DataPoint">here</a>.

# Usage
The below code can be used in a .NET Core project, a test project is also included in the GitHub solution.

```C#
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create client
            MetOfficeDataPointClient client = new MetOfficeDataPointClient("{APIKEY}");

            // Get all sites
            SiteListResponse siteListResponse = client.GetAllSites().Result;

            // Get available forcasts
            AvailableTimeStampsResponse availableTimeStampsResponse = client.GetAvailableTimestamps().Result;

            // Get all forecasts
            ForecastResponse forecastResponse = client.GetForecasts().Result;
        }
    }
```