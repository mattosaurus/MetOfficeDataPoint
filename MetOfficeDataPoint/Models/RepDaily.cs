using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class RepDaily
    {
        public RepDailyDay Day { get; set; }

        public RepDailyNight Night { get; set; }
    }
}
