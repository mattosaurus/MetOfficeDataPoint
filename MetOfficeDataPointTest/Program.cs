using GeoCoordinatePortable;
using MetOfficeDataPoint;
using MetOfficeDataPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPointTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create client
            MetOfficeDataPointClient client = new MetOfficeDataPointClient("78b6eede-0692-433c-a35b-154332355218");

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
