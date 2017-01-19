using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class Resource
    {
        /// <summary>
        /// This describes the date and time at which the data was last updated, expressed according to the ISO 8601 combined date and time convention
        /// </summary>
        [JsonProperty("dataDate")]
        public string DataDate { get; set; }

        /// <summary>
        /// This refers to the temporal resolution of the web service for which the capabilities have been returned. This is set to the temporal resolution specified in the query
        /// </summary>
        [JsonProperty("res")]
        public string Resolution { get; set; }

        /// <summary>
        /// This corresponds to the resource type of the web service for which the capabilities have been returned
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The value of the Resource object comprises a single TimeSteps object, which in turn contains a set of TS objects. The value of each TS object (or each element in the TS array in the JSON representation) provides a description of a single available timestep, expressed according to the ISO 8601 combined date and time convention.
        /// </summary>
        [JsonProperty("TimeSteps")]
        public TimeSteps TimeSteps { get; set; }
    }
}
