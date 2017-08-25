using MetOfficeDataPoint;
using MetOfficeDataPoint.Models;
using MetOfficeDataPoint.Models.GeoCoordinate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetOfficeDataPointTest461
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create client
            MetOfficeDataPointClient client = new MetOfficeDataPointClient("<API_KEY>");

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
}
