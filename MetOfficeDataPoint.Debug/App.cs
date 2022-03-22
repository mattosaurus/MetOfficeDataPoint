using MetOfficeDataPoint.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Debug
{
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
            var sites = await _metOfficeDataPointService.GetAllSitesAsync();

            var times = await _metOfficeDataPointService.GetAvailableTimestampsAsync();

            var forecasts = await _metOfficeDataPointService.GetForecasts3HourlyAsync();
        }
    }
}
