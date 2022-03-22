using MetOfficeDataPoint.Models;
using MetOfficeDataPoint.Models.GeoCoordinate;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;
using System.Net;
using System.Net.Http.Json;

namespace MetOfficeDataPoint.Services
{
    public class MetOfficeDataPointService : IMetOfficeDataPointService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<MetOfficeDataPointService> _logger;
        private readonly MetOfficeDataPointOptions _options;

        public MetOfficeDataPointService(HttpClient httpClient, ILoggerFactory loggerFactory, IOptions<MetOfficeDataPointOptions> options)
        {
            _httpClient = httpClient;
            _logger = loggerFactory.CreateLogger<MetOfficeDataPointService>();
            _options = options.Value;
        }

        public async Task<SiteListResponse> GetAllSitesAsync()
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, "wxfcs/all/json/sitelist", new Dictionary<string, string>()
            {
                ["res"] = "daily"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<SiteListResponse>() ?? throw new ArgumentNullException();
        }

        public async Task<AvailableTimeStampsResponse> GetAvailableTimestampsAsync()
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, "wxfcs/all/json/capabilities", new Dictionary<string, string>()
            {
                ["res"] = "3hourly"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<AvailableTimeStampsResponse>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync()
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, "wxfcs/all/json/all", new Dictionary<string, string>()
            {
                ["res"] = "3hourly"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponse3Hourly>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync(string time)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, "wxfcs/all/json/all", new Dictionary<string, string>()
            {
                ["res"] = "3hourly",
                ["time"] = time
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponse3Hourly>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync(int locationId)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"wxfcs/all/json/{locationId}", new Dictionary<string, string>()
            {
                ["res"] = "3hourly"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponse3Hourly>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponse3Hourly> GetForecasts3HourlyAsync(int locationId, string time)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"wxfcs/all/json/{locationId}", new Dictionary<string, string>()
            {
                ["res"] = "3hourly",
                ["time"] = time
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponse3Hourly>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponseDaily> GetForecastsDailyAsync()
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"wxfcs/all/json/all", new Dictionary<string, string>()
            {
                ["res"] = "daily"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponseDaily>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponseDaily> GetForecastsDailyAsync(int locationId)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"wxfcs/all/json/{locationId}", new Dictionary<string, string>()
            {
                ["res"] = "daily"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponseDaily>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponse3Hourly> GetHistoricalObservationsAsync()
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"wxobs/all/json/all", new Dictionary<string, string>()
            {
                ["res"] = "hourly"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponse3Hourly>() ?? throw new ArgumentNullException();
        }

        public async Task<ForecastResponse3Hourly> GetHistoricalObservationsAsync(int locationId)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"wxobs/all/json/{locationId}", new Dictionary<string, string>()
            {
                ["res"] = "hourly"
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<ForecastResponse3Hourly>() ?? throw new ArgumentNullException();
        }

        public async Task<Location> GetClosestSiteAsync(GeoCoordinate geoCoordinate)
        {
            // Get all sites
            SiteListResponse siteListResponse = await GetAllSitesAsync();

            // Find nearest coordinates
            GeoCoordinate nearest = siteListResponse
                .Locations
                .Location
                .Select(x => new GeoCoordinate(x.Latitude, x.Longitude))
                .OrderBy(x => x.GetDistanceTo(geoCoordinate))
                .First();

            // Find site matching nearest coordinates
            Location location = siteListResponse
                .Locations
                .Location
                .Find(x => x.Latitude == nearest.Latitude && x.Longitude == nearest.Longitude);

            return location;
        }

        private HttpRequestMessage CreateHttpRequestMessage(HttpMethod httpMethod, string requestUri)
        {
            Dictionary<string, string> queryParameters = new Dictionary<string, string>()
            {
                ["key"] = _options.ApiKey
            };

            string uri = QueryHelpers.AddQueryString(requestUri, queryParameters);

            return new HttpRequestMessage(httpMethod, uri);
        }

        private HttpRequestMessage CreateHttpRequestMessage(HttpMethod httpMethod, string requestUri, Dictionary<string, string> queryParameters)
        {
            queryParameters.Add("key", _options.ApiKey);

            string uri = QueryHelpers.AddQueryString(requestUri, queryParameters);

            return new HttpRequestMessage(httpMethod, uri);
        }
    }
}
