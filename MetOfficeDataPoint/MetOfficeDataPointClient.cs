using MetOfficeDataPoint.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MetOfficeDataPoint
{
    public class MetOfficeDataPointClient
    {
        private readonly string _apiKey;

        public MetOfficeDataPointClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<SiteListResponse> GetAllSites(string resolution = "daily")
        {
            string url = "http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/sitelist?res=" + resolution + "&key=" + _apiKey;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(new Uri(url));

                response.EnsureSuccessStatusCode();
                SiteListResponse siteListResponse = JsonConvert.DeserializeObject<SiteListResponse>(await response.Content.ReadAsStringAsync());

                return siteListResponse;
            }
        }

        public async Task<AvailableTimeStampsResponse> GetAvailableTimestamps(string resolution = "3hourly")
        {
            string url = "http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/capabilities?res=" + resolution + "&key=" + _apiKey;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(new Uri(url));

                response.EnsureSuccessStatusCode();
                AvailableTimeStampsResponse siteListResponse = JsonConvert.DeserializeObject<AvailableTimeStampsResponse>(await response.Content.ReadAsStringAsync());

                return siteListResponse;
            }
        }

        public async Task<ForecastResponse> GetForecasts(string resolution = "3hourly", string time = null, int locationId = 0)
        {
            string url = "http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/";

            if (locationId > 0)
            {
                url = "http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/" + locationId.ToString() +  "?res=" + resolution + "&key=" + _apiKey;
            }
            else
            {
                url = "http://datapoint.metoffice.gov.uk/public/data/val/wxfcs/all/json/all?res=" + resolution + "&key=" + _apiKey;
            }

            if (!string.IsNullOrEmpty(time))
            {
                url += "&time=" + time;
            }

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(new Uri(url));

                response.EnsureSuccessStatusCode();
                ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(await response.Content.ReadAsStringAsync());

                return forecastResponse;
            }
        }
    }
}
