using MetOfficeDataPoint.Helpers;
using MetOfficeDataPoint.Models;
using MetOfficeDataPoint.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Extensions
{
    public static class MetOfficeDataPointServiceCollectionExtensions
    {
        public static IServiceCollection AddMetOfficeDataPointService(this IServiceCollection collection, Action<MetOfficeDataPointOptions> setupAction)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

            // Add Met Office HTTP Client
            collection.AddHttpClient<IMetOfficeDataPointService, MetOfficeDataPointService>(client =>
            {
                client.BaseAddress = new Uri("http://datapoint.metoffice.gov.uk/public/data/val/");
            });

            collection.Configure(setupAction);
            return collection;
        }

        public static IServiceCollection AddMetOfficeDataPointService(this IServiceCollection collection, string apiKey)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (apiKey == null) throw new ArgumentNullException(nameof(apiKey));

            collection.AddHttpClient<IMetOfficeDataPointService, MetOfficeDataPointService>(client =>
            {
                client.BaseAddress = new Uri("http://datapoint.metoffice.gov.uk/public/data/val/");
            });

            collection.AddOptions<MetOfficeDataPointOptions>().Configure(options =>
            {
                options.ApiKey = apiKey;
            });

            return collection;
        }

        public static IServiceCollection AddMetOfficeDataPointService(this IServiceCollection collection, IConfigurationSection configuration)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            // Add Met Office HTTP Client
            collection.AddHttpClient<IMetOfficeDataPointService, MetOfficeDataPointService>(client =>
            {
                client.BaseAddress = new Uri("http://datapoint.metoffice.gov.uk/public/data/val/");
            });

            collection.Configure<MetOfficeDataPointOptions>(configuration);
            return collection;
        }
    }
}
