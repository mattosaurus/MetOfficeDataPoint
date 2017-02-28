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
            MetOfficeDataPointClient client = new MetOfficeDataPointClient("{TOKEN}");

            // Get all sites
            SiteListResponse siteListResponse = client.GetAllSites().Result;

            // Get available forcasts
            AvailableTimeStampsResponse availableTimeStampsResponse = client.GetAvailableTimestamps().Result;

            // Get all 3 hourly forecasts
            ForecastResponse3Hourly forecastResponse3Hourly = client.GetForecasts3Hourly().Result;

            // Get all daily forecasts
            ForecastResponseDaily forecastResponseDaily = client.GetForecastsDaily(14).Result;
        }
    }
}
