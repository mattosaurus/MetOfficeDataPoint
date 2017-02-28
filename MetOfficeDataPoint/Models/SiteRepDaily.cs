using MetOfficeDataPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Models
{
    public class SiteRepDaily
    {
        public Wx Wx { get; set; }

        public DVDaily DV { get; set; }
    }
}
