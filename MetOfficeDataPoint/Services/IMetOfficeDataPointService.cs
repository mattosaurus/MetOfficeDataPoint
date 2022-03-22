using MetOfficeDataPoint.Models;
using MetOfficeDataPoint.Models.GeoCoordinate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Services
{
    public interface IMetOfficeDataPointService
    {
        Task<SiteListResponse> GetAllSitesAsync();

        Task<AvailableTimeStampsResponse> GetAvailableTimestampsAsync();

        Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync();

        Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync(string time);

        Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync(int locationId);

        Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync(int locationId, string time);

        Task<ForecastResponseDaily> GetForecastsDailyAsync();

        Task<ForecastResponseDaily> GetForecastsDailyAsync(int locationId);

        Task<ForecastResponse3Hourly> GetHistoricalObservationsAsync();

        Task<ForecastResponse3Hourly> GetHistoricalObservationsAsync(int locationId);

        Task<Location> GetClosestSiteAsync(GeoCoordinate geoCoordinate);
    }
}
